using System.Diagnostics.Metrics;
using System.Text;

namespace Noughts_and_Crosses_game
{
    public partial class TitlePage : Form
    {
        //global variables
        //arrays to change panels etc. quickly
        private Panel[] panels;
        private Button[] playingSquares;
        private PictureBox[] counters;

        //dictionaries to look up the correct playingSquare or counter picture
        private Dictionary<Tuple<int, int>, Button> psLookUp;
        private Dictionary<Tuple<int, int>, PictureBox> counterLookUp;

        //set-up a blank 3x3 array for the board and a list of moves taken by co-ordinate
        private char[,] board = PlayingTools.CreateBoard();
        private List<Tuple<int, int>> moves = new();

        //record the player choices for type and difficulty of game
        private bool two_player = true;
        private int difficulty = 0;

        //player_start shows who is x, i.e. who starts, player_move switches to show who just took a move for win conditions
        private bool player_start = true;
        private bool player_move = true;

        //time left used for timer countdowns
        private int timeLeft;



        public TitlePage()
        {
            InitializeComponent();

            //set up arrays and lists
            panels = new[] { loadingPanel, titlePanel, opponentPanel, difficultyPanel, choosePanel, playingPanel };
            playingSquares = new[] { playingSquare00, playingSquare01, playingSquare02, playingSquare10, playingSquare11, playingSquare12, playingSquare20, playingSquare21, playingSquare22 };
            counters = new[] { counter00, counter01, counter02, counter10, counter11, counter12, counter20, counter21, counter22 };

            //set up dictionaries
            psLookUp = new();
            psLookUp.Add(Tuple.Create(0, 0), playingSquare00);
            psLookUp.Add(Tuple.Create(0, 1), playingSquare01);
            psLookUp.Add(Tuple.Create(0, 2), playingSquare02);
            psLookUp.Add(Tuple.Create(1, 0), playingSquare10);
            psLookUp.Add(Tuple.Create(1, 1), playingSquare11);
            psLookUp.Add(Tuple.Create(1, 2), playingSquare12);
            psLookUp.Add(Tuple.Create(2, 0), playingSquare20);
            psLookUp.Add(Tuple.Create(2, 1), playingSquare21);
            psLookUp.Add(Tuple.Create(2, 2), playingSquare22);

            counterLookUp = new();
            counterLookUp.Add(Tuple.Create(0, 0), counter00);
            counterLookUp.Add(Tuple.Create(0, 1), counter01);
            counterLookUp.Add(Tuple.Create(0, 2), counter02);
            counterLookUp.Add(Tuple.Create(1, 0), counter10);
            counterLookUp.Add(Tuple.Create(1, 1), counter11);
            counterLookUp.Add(Tuple.Create(1, 2), counter12);
            counterLookUp.Add(Tuple.Create(2, 0), counter20);
            counterLookUp.Add(Tuple.Create(2, 1), counter21);
            counterLookUp.Add(Tuple.Create(2, 2), counter22);

            StartGame();
        }

        //Start a new game - run opening panel and ensure all other panels in correct position - move to TitlePanel when finished
        private void StartGame()
        {
            //load the loadingPanel for 3 seconds, then switch to the titlePanel
            ChangePanel(loadingPanel, panels);

            //set up and run timer for three seconds
            timeLeft = 3;
            loadingTimer.Start();

        }

        //Changes the panel to the desired panel
        private void ChangePanel(Panel chosen_panel, Panel[] panels)
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = panel == chosen_panel;

            }
        }

        //Uses the information gathered to run the game on the playingPanel
        private void SetUpGame()
        {

            //set up the playing board

            foreach (PictureBox c in counters)
            {
                c.Image = Properties.Resources.blank_counter;
                c.SendToBack();
            }

            //hide the reset button
            resetButton.Enabled = false;
            resetButton.SendToBack();

            //For computer games - displays who starts
            if (!two_player)
            {

                playingScreen.Text = (player_start) ? "You are playing as X - your move." : "You are O. The computer is playing.";
                
            }

            //Enables all the playingSquares if player_starts else disables all
            foreach (Button b in playingSquares)
            {
                b.Enabled = (player_start) ? true : false;
            }

            //play an intial computer move, if the computer is starting
            if (!player_start)
            {
                //add a delay to keep initial message displayed
                timeLeft = 3;
                computerStartsTimer.Start();

                //computer move made when the timer ends - see computerStartsTimer_Tick
                
            }

        }

        //return the move made when a player clicks on a square to alter the board and add to the moves list
        private void PlayerMove(Button playing_square, PictureBox counter)
        {

            //disable the button so that it cannot be used again
            playing_square.Enabled = false;

            //select correct picture
            if (player_move)
            {
                counter.Image = (player_start) ? Properties.Resources.x_counter : Properties.Resources.o_counter;

            }
            else
            {
                counter.Image = (player_start) ? Properties.Resources.o_counter : Properties.Resources.x_counter;
            }

            counter.BringToFront();

        }



        //runs a round of the game when a square is clicked and checks for a winner after each turn
        private void PlayGame(Button playing_square, PictureBox counter, int row, int column)
        {
            PlayerMove(playing_square, counter);

            //update the board and moves list, remove playingSquare from the unused list
            board[row, column] = (player_move) ? ((player_start) ? 'X' : 'O') : ((player_start) ? 'O' : 'X');
            moves.Add(Tuple.Create(row, column));

            //check if the player has won
            if (PlayingTools.CheckWin(board) || moves.Count() == 9)
            {
                GameOver(two_player, player_move);
            }
            else if (two_player)
            {
                //update the player_move and the playingScreen
                player_move = (player_move) ? false : true;
                playingScreen.Text = (player_move) ? "X to play." : "O to play.";
            }
            else
            {

                //change the player_move bool to switch whose move it is and update the playingScreen
                player_move = false;
                playingScreen.Text = "The computer is taking its move.";

                //the computer takes its move
                //give the computer time to make its move - between 2 and 4 seconds
                Random rnd = new Random();
                //timeLeft = rnd.Next(2, 5);
                timeLeft = 3;
                computerTimer.Start();

                //during the computer turn, disable all playingSquares
                foreach (Button b in playingSquares)
                {
                    b.Enabled = false;
                }

            }
        }

        //BUTTONS

        //Start a game - move from TitlePanel to OpponentPanel
        private void StartButton_Click(object sender, EventArgs e)
        {
            ChangePanel(opponentPanel, panels);
        }

        //Choose an opponent - two-player, then choose your character, or computer, then choose difficulty
        private void opponentButtonPlayer_Click(object sender, EventArgs e)
        {
            //the players can play in either order - they can choose on the playingPanel - 'X starts'
            ChangePanel(playingPanel, panels);

            //two_player is already true
            //player_start is already true and player_move is already true for player one

            //play the game
            SetUpGame();
        }
        private void opponentButtonComputer_Click(object sender, EventArgs e)
        {
            ChangePanel(difficultyPanel, panels);

            //update the two_player bool
            two_player = false;

        }

        //Choose the difficulty setting for a computer game, then choose your character
        private void difficultyButtonEasy_Click(object sender, EventArgs e)
        {
            ChangePanel(choosePanel, panels);

            //update the difficulty level
            difficulty = 1;

        }

        private void difficultyButtonMedium_Click(object sender, EventArgs e)
        {
            ChangePanel(choosePanel, panels);

            //update the difficulty level
            difficulty = 2;

        }

        private void difficultyButtonHard_Click(object sender, EventArgs e)
        {
            ChangePanel(choosePanel, panels);

            //update the difficulty level
            difficulty = 3;
        }

        //Choose to start or go second, or let the computer decide, then go to the playing board
        private void chooseButtonX_Click(object sender, EventArgs e)
        {
            ChangePanel(playingPanel, panels);

            //player_start is already true and player_move is already true

            //play the game
            SetUpGame();

        }

        private void chooseButtonO_Click(object sender, EventArgs e)
        {
            ChangePanel(playingPanel, panels);

            //player is not starting - update bool
            player_start = false;
            player_move = false;

            //play the game
            SetUpGame();
        }

        private void chooseButtonRandom_Click(object sender, EventArgs e)
        {
            ChangePanel(playingPanel, panels);

            //update bool for random choice made
            player_start = PlayingTools.RandomChooseStart();
            player_move = (player_start) ? true : false;

            //play the game
            SetUpGame();
        }

        //Playing squares for the game board - adds the correct character when clicked
        private void playingSquare00_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare00, counter00, 0, 0);

        }

        private void playingSquare01_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare01, counter01, 0, 1);

        }

        private void playingSquare02_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare02, counter02, 0, 2);

        }

        private void playingSquare10_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare10, counter10, 1, 0);

        }

        private void playingSquare11_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare11, counter11, 1, 1);

        }

        private void playingSquare12_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare12, counter12, 1, 2);

        }

        private void playingSquare20_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare20, counter20, 2, 0);

        }

        private void playingSquare21_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare21, counter21, 2, 1);

        }

        private void playingSquare22_Click(object sender, EventArgs e)
        {

            PlayGame(playingSquare22, counter22, 2, 2);

        }

        //button displayed when game over to return to the start menu
        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //TIMERS

        //Timer for loading screen - counts down on each tick and then changes the panel
        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0)
            {
                loadingTimer.Stop();
                ChangePanel(titlePanel, panels);

            }
        }
              
        //timer to delay before reset button is displayed
        private void resetTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0)
            {
                //enabled the reset button
                resetButton.Enabled = true;
                resetButton.BringToFront();

                resetTimer.Stop();
            }
        }

        //adds a delay for the computer's turn
        private void computerTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            //when the time is up, let the player know that it is their turn and enable the unused playing squares
            if (timeLeft <= 0)
            {
                //set up a tuple to hold the computer move
                Tuple<int, int> computer_move = Tuple.Create(0, 0);

                //update the board and moves list with the computer's move - check the difficulty level for the move played
                switch (difficulty)
                {
                    case 1:
                        computer_move = PlayingTools.ComputerMoveEasy(board, player_start);
                        break;

                    case 2:
                        computer_move = PlayingTools.ComputerMoveMedium(board, player_start, moves);
                        break;

                    default:
                        computer_move = PlayingTools.ComputerMoveHard(board, player_start, moves);
                        break;
                }

                //update the board and add the move to the moves list
                board[computer_move.Item1, computer_move.Item2] = (player_start) ? 'O' : 'X';
                moves.Add(computer_move);

                //update the image on the board
                counterLookUp[computer_move].Image = (player_start) ? Properties.Resources.o_counter : Properties.Resources.x_counter;
                counterLookUp[computer_move].BringToFront();

                //check if the computer has won
                if (PlayingTools.CheckWin(board) || moves.Count() == 9)
                {
                    GameOver(two_player, player_move);
                }
                else
                {
                    //update the player_move bool and the playingScreen
                    player_move = true;
                }

                if (!PlayingTools.CheckWin(board) && moves.Count() != 9)
                {
                    playingScreen.Text = "It's your turn.";
                }

                foreach (Button b in playingSquares)
                {
                    b.Enabled = true;
                }

                foreach (Tuple<int, int> t in moves)
                {
                    psLookUp[t].Enabled = false;
                   
                }

                computerTimer.Stop();
            }

        }

        //if the computer make the opening move, this timer builds in a delay before the move is played
        private void computerStartsTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0)
            {

                //set up a tuple to hold the computer move
                Tuple<int, int> computer_move = Tuple.Create(0, 0);

                //choose a computer move - check the difficulty level for the move played
                switch (difficulty)
                {
                    case 1:
                        computer_move = PlayingTools.ComputerMoveEasy(board, player_start);
                        break;

                    case 2:
                        computer_move = PlayingTools.ComputerMoveMedium(board, player_start, moves);
                        break;

                    default:
                        computer_move = PlayingTools.ComputerMoveHard(board, player_start, moves);
                        break;
                }

                //update the board and add the move to the moves list
                board[computer_move.Item1, computer_move.Item2] = 'X';
                moves.Add(computer_move);

                ////update the image on the board
                counterLookUp[computer_move].Image = Properties.Resources.x_counter;
                counterLookUp[computer_move].BringToFront();

                //enable the playing squares and disable the square that has been played
                foreach (Button b in playingSquares)
                {
                    b.Enabled = true;
                }
                psLookUp[computer_move].Enabled = false;
                
                //update the player_move bool and the playingScreen
                player_move = true;
                playingScreen.Text = "It's your move.";

                //stop the timer
                computerStartsTimer.Stop();
            }
        }
        
        //GAME OVER METHODS
        
        //game over conditions
        private void GameOver(bool two_player, bool player_move)
        {
            foreach (Button b in playingSquares)
            {
                b.Enabled = false;
            }

            if (moves.Count() == 9)
            {
                playingScreen.Text = "It is a draw!";
            }
            else if (!two_player)
            {
                playingScreen.Text = (player_move) ? "Congratulations! You are the winner!" : "The computer wins. Unlucky!";
            }
            else
            {
                playingScreen.Text = (player_move) ? "Congratulations! X is the winner!" : "Congratulations! O is the winner!";
            }


            timeLeft = 3;
            resetTimer.Start();

        }

        //start a new game
        private void Reset()
        {
            ChangePanel(titlePanel, panels);

            //reset the board, the moves list and the playingScreen
            board = PlayingTools.CreateBoard();
            moves = new();
            playingScreen.Text = "X to play first. Good luck!";

        }

    }


}
