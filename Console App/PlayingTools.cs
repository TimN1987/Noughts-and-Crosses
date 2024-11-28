using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Noughts_and_Crosses
{
    public static class PlayingTools
    {

        //method to set up a console game where the player can choose which game they'd like to play or exit
        public static void LoadGame()
        {
            //assume the player hasn't chosen to exit the application yet, nor have they made a valid choice of game type
            bool exit = false;
            bool valid_choice = false;
            int action = 0;

            //list of acceptable choices of game type
            string[] acceptable_choices = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];

            //run the opening banner and introduce the game choices
            Banner();
            Console.WriteLine("\nWelcome to Noughts and Crosses.\n\nType a number to choose your game type and level of difficulty.\n");

            while (!exit)
            {
                while (!valid_choice)
                {
                    //display the possible choices
                    Console.WriteLine("1 - Two player (choose who starts);\n2 - Two player (random start);\n3 - Easy (choose who starts);\n4 - Easy (random start);\n" +
                    "5 - Medium (choose who starts);\n6 - Medium (random start);\n7 - Hard (choose who starts);\n8 - Hard (random start);\n9 - Exit game.");
                    string? choice = Console.ReadLine();

                    //check that the player has entered a digit
                    valid_choice = acceptable_choices.Contains(choice);

                    if (valid_choice)
                    {
                        //convert the choice to an int to choose the game to load
                        action = Convert.ToInt32(choice);
                    }
                    else
                    {
                        //if an invalid choice was made, request a new choice and return to the start of the loop
                        Console.WriteLine("Please choose again. You must type a number from 1 - 9 to choose.");
                    }
                }

                //use the player's choice to create a game board and load the correct game or to set exit to true and end the application
                switch (action)
                {
                    case 1:
                        char[,] board1 = StartGame();
                        PlayGameTwoPlayer(board1);
                        break;

                    case 2:
                        char[,] board2 = StartGame();
                        PlayGameTwoPlayerRandom(board2);
                        break;

                    case 3:
                        char[,] board3 = StartGame();
                        PlayGameCompEasy(board3);
                        break;

                    case 4:
                        char[,] board4 = StartGame();
                        PlayGameCompEasyRandom(board4);
                        break;

                    case 5:
                        char[,] board5 = StartGame();
                        PlayGameCompMedium(board5);
                        break;

                    case 6:
                        char[,] board6 = StartGame();
                        PlayGameCompMediumRandom(board6);
                        break;

                    case 7:
                        char[,] board7 = StartGame();
                        PlayGameCompHard(board7);
                        break;

                    case 8:
                        char[,] board8 = StartGame();
                        PlayGameCompHardRandom(board8);
                        break;

                    case 9:
                        exit = true;
                        Console.WriteLine("Thank you for playing Noughts and Crosses.");
                        break;

                    default:
                        Console.WriteLine("Please choose again. You must type a number from 1 - 9 to choose.");
                        break;
                }
                action = 0;
                valid_choice = false;

                if (!exit)
                {
                    Console.WriteLine("\nThank you for playing!\n\nChoose another action. Type a number from 1-9 to choose.");
                }

            }

            Environment.Exit(0);
        }

        //method to display an opening banner when the game is loaded
        private static void Banner()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                "+++++++++++++++++++++ NOUGHTS AND CROSSES +++++++++++++++++++++\n" +
                "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine();
            Console.ResetColor();
        }

        //method to set up any empty 3x3 array full of empty spaces
        private static char[,] CreateBoard()
        {
            char[,] board = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            return board;
        }

        //method to print an image of the board for console play
        private static void PrintBoard(char[,] board)
        {

            //strings to print each line of the board
            string dividing_line = "  +---+---+---+";
            string blank_line = "  |   |   |   |";
            string line_one = $"1 | {board[0, 0]} | {board[0, 1]} | {board[0, 2]} |";
            string line_two = $"2 | {board[1, 0]} | {board[1, 1]} | {board[1, 2]} |";
            string line_three = $"3 | {board[2, 0]} | {board[2, 1]} | {board[2, 2]} |";
            string final_line = "    1   2   3  ";

            Console.WriteLine($"{dividing_line}\n{blank_line}\n{line_one}\n{blank_line}\n{dividing_line}\n" +
                $"{blank_line}\n{line_two}\n{blank_line}\n{dividing_line}\n" +
                $"{blank_line}\n{line_three}\n{blank_line}\n{dividing_line}\n{final_line}");
        }

        //method to start the game by creating a board and printing an empty version of the board
        public static char[,] StartGame()
        {

            char[,] board = CreateBoard();
            PrintBoard(board);
            return board;
        }
        
        //a method to let the human player choose X or O
        public static bool ChooseStartCharacter()
        {
            //booleans to track if a workable choice has been made or if an alternative choice needs to be made; also to track whether or not the human player starts to return
            bool player_start = false;
            bool viable_choice = false;

            Console.WriteLine("Choose X or O. X plays first.");

            //exits loop when a viable choice of character has been made
            while (!viable_choice)
            {
                string? choice = Console.ReadLine();
                if (choice == "x" || choice == "X")
                {
                    player_start = true;
                    viable_choice = true;
                }
                else if (choice == "o" || choice == "O")
                {
                    viable_choice = true;
                }
                else
                {
                    Console.WriteLine("You must choose X or O. Try again.");
                }
            }

            //return false if the computer starts and true if the player starts
            return player_start;
        }

        //method to let player choose their counter in a two player game
        static bool ChooseStartCharacterTwoPlayer()
        {
            //booleans to track if a workable choice has been made or if an alternative choice needs to be made; also to track whether or not the human player starts to return
            bool player_start = false;
            bool viable_choice = false;

            Console.WriteLine("Player One, choose X or O. X plays first.");

            //exits loop when a viable choice of character has been made
            while (!viable_choice)
            {
                string? choice = Console.ReadLine();
                if (choice == "x" || choice == "X")
                {
                    player_start = true;
                    viable_choice = true;
                }
                else if (choice == "o" || choice == "O")
                {
                    viable_choice = true;
                }
                else
                {
                    Console.WriteLine("You must choose X or O. Try again.");
                }
            }

            //return false if the computer starts and true if the player starts
            return player_start;
        }

        //use a random generator to decide who starts
        static bool RandomChooseStart()
        {
            Random rnd = new Random();
            bool player_start = false;

            //choose a random number 0 or 1 - 50% chance of choosing player start or not
            if (rnd.Next(2) == 0)
            {
                player_start = true;
            }

            char counter = (player_start) ? 'X' : 'O';

            Console.WriteLine($"You are {counter}. X plays first.");

            return player_start;
        }

        //method to check if there is a winning line of three X or O - returns true if winning line found
        static bool CheckWin(char[,] board)
        {
            //assume no winning line - correct to true if a winning line is found
            bool win = false;

            //check each horizontal row to see if all the characters are the same but not empty
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] && board[0, 0] != ' ')
            {
                win = true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2] && board[1, 0] != ' ')
            {
                win = true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] && board[2, 0] != ' ')
            {
                win = true;
            }
            //check each vertical row to see if all the characters are the same but not empty
            else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0] && board[0, 0] != ' ')
            {
                win = true;
            }
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1] && board[0, 1] != ' ')
            {
                win = true;
            }
            else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2] && board[0, 2] != ' ')
            {
                win = true;
            }
            //check the two diagonals to see if all the cahracters are the same but not empty
            else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != ' ')
            {
                win = true;
            }
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != ' ')
            {
                win = true;
            }

            return win;
        }

        //method to look for any potential winning moves to make or block - alternatively, it returns a random move
        static Tuple<int, int> FindWinningMove(char[,] board, bool player_start)
        {
            //assume we will not find a winning move
            bool winning_move_found = false;
            int row = 0;
            int column = 0;

            //run through the board and test each empty space to see if it produces a win, then return the space to empty and save the row and column
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ' && !winning_move_found)
                    {
                        if (player_start)
                        {
                            board[i, j] = 'O';
                        }
                        else
                        {
                            board[i, j] = 'X';
                        }
                        if (CheckWin(board))
                        {
                            row = i;
                            column = j;
                            winning_move_found = true;
                        }
                        board[i, j] = ' ';
                    }
                }
            }

            //if no winning move is found to end the game, repeat the process to check if the opponent could play a winning move - if so, choose this space to block it
            if (!winning_move_found)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == ' ')
                        {
                            if (player_start)
                            {
                                board[i, j] = 'X';
                            }
                            else
                            {
                                board[i, j] = 'O';
                            }
                            if (CheckWin(board))
                            {
                                row = i;
                                column = j;
                                winning_move_found = true;
                            }
                            board[i, j] = ' ';
                        }
                    }
                }
            }

            //if there is still no move found, assign the row and column to -1 so that it is easy to check whether another move needs to be found
            if (!winning_move_found)
            {
                row = -1;
                column = -1;
            }

            //return the chosen row and column as a tuple
            return Tuple.Create(row, column);
        }

        //method to declare the winner or a draw when the game over conditions are met
        static void GameOver(bool player_move, bool draw)
        {
            if (draw)
            {
                Console.WriteLine("There are no more spaces. It's a draw!");
            }
            else if (player_move)
            {
                Console.WriteLine("Congratulations! You have won!");
            }
            else
            {
                Console.WriteLine("Unlucky this time! The computer has won!");
            }
        }

        //variation of game over for a two player game
        static void GameOverTwoPlayer(bool player1_move, bool draw)
        {
            if (draw)
            {
                Console.WriteLine("There are no more spaces. It's a draw!");
            }
            else if (player1_move)
            {
                Console.WriteLine("Congratulations, Player One! You have won!");
            }
            else
            {
                Console.WriteLine("Congratulations, Player Two! You have won!");
            }
        }

        //method to allow a player to make their move and alter the game board
        public static Tuple<int, int> PlayerMove(char[,] board, bool player_start)
        {
            //record acceptable answers and set up a row and column value
            string[] acceptable_answers = ["1", "2", "3"];

            int row = 0;
            int column = 0;

            //assume that no valid move has been chosen so far
            bool row_null = true;
            bool col_null = true;
            bool move_made = false;

            //continue asking for a move until the player has chosen a valid row and column
            while (!move_made)
            {
                Console.WriteLine("Choose a row and a column for your move.");

                //check that the player's row value is on the board
                while (row_null)
                {
                    Console.WriteLine("Choose a row - 1, 2 or 3.");
                    string? row_string = Console.ReadLine();

                    if (acceptable_answers.Contains(row_string))
                    {
                        row_null = false;
                        row = Convert.ToInt32(row_string) - 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }

                }

                //check that the column is on the board
                while (col_null)
                {
                    Console.WriteLine("Choose a column - 1, 2 or 3.");
                    string? col_string = Console.ReadLine();

                    if (acceptable_answers.Contains(col_string))
                    {
                        col_null = false;
                        column = Convert.ToInt32(col_string) - 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }

                }

                //check that the suggested move is an empty space - else ask for a new move
                if (board[row, column] == ' ')
                {
                    if (player_start)
                    {
                        board[row, column] = 'X';
                    }
                    else
                    {
                        board[row, column] = 'O';
                    }

                    move_made = true;

                }
                else
                {
                    Console.WriteLine("This space has been taken. Try again.");
                    row_null = true;
                    col_null = true;
                }



            }

            return Tuple.Create(row, column);

        }

        //method to choose random spaces for an easy computer move
        public static void ComputerMoveEasy(char[,] board, bool player_start)
        {
            //assume that the starting move is taken - set up key values
            Random rnd = new Random();
            bool valid_choice = false;
            int row = 0;
            int column = 0;

            //choose random rows and columns from 1-3 until an empty space is found
            while (!valid_choice)
            {
                row = rnd.Next(3);
                column = rnd.Next(3);

                if (board[row, column] == ' ')
                {
                    valid_choice = true;
                }
            }

            //place the correct counter on the game board
            board[row, column] = (player_start) ? 'O' : 'X';

        }

        //method to return a medium move - choose randomly between a hard move or an easy move
        public static Tuple<int, int> ComputerMoveMedium(char[,] board, bool player_start, List<Tuple<int, int>> moves)
        {
            //set up a random variable for choosing a hard move or an easy move
            Random rnd = new Random();
            //assume that a valid choice has not been made for the easy move
            bool valid_choice = false;
            //set up a row, column value and a tuple to hold the move
            int row = 0;
            int column = 0;
            Tuple<int, int> move = Tuple.Create(0, 0);

            //use a random choice of zero or one to chose the easy or hard moves - this could be varied to change the percentage of easy or hard moves and alter the difficulty
            int choice = rnd.Next(2);

            if (choice == 0)
            {

                while (!valid_choice)
                {
                    row = rnd.Next(3);
                    column = rnd.Next(3);

                    if (board[row, column] == ' ')
                    {
                        valid_choice = true;
                    }
                }

                //add the correct counter to the chosen space
                if (player_start)
                {
                    board[row, column] = 'O';
                }
                else
                {
                    board[row, column] = 'X';
                }

                move = Tuple.Create(row, column);
            }
            else
            {
                //play the hard move - this will automatically add the character to the board
                move = ComputerMoveHard(board, player_start, moves);
            }

            return move;

        }

        //method to return a hard computer move and alter the game board - computer plays the correct strategic move to ensure a draw and try to force a win
        public static Tuple<int, int> ComputerMoveHard(char[,] board, bool player_start, List<Tuple<int, int>> moves)
        {            
            //set up values that will be used in this method
            Random rnd = new Random();
            int moves_completed = moves.Count();
            int row_played = 0;
            int col_played = 0;
            int comp_row = 0;
            int comp_col = 0;
            Tuple<int, int> possible_move = Tuple.Create(0, 0);

            string[] acceptable_answers = ["1", "2", "3"];

            int row = 0;
            int column = 0;
            int choice = 0;
            
            //have a list of corner and edge squares to compare to
            List<(int, int)> corners = new List<(int, int)> {(0, 0), (0, 2), (2, 0), (2, 2)};
            List<(int, int)> edges = new List<(int, int)> { (0, 1), (1, 0), (1, 2), (2, 1) };

            //use the number of moves played so far to decide how to respond and how to check what has happened thus far
            switch (moves_completed)
            {
                //if this is the opening move, choose a random corner to start with - any corner is equally valid due to the symmetry of the board
                case 0:
                    choice = rnd.Next(4);
                    switch (choice)
                    {
                        case 0:
                            row = 0;
                            column = 0;
                            break;

                        case 1:
                            row = 0;
                            column = 2;
                            break;

                        case 2:
                            row = 2;
                            column = 0;
                            break;

                        default:
                            row = 2;
                            column = 2;
                            break;
                    }
                    break;

                case 1:
                  
                    //Check which square the opponent played
                    row_played = moves[0].Item1;
                    col_played = moves[0].Item2;

                    //Choose a random corner if the opponent chose the centre square
                    if (row_played == 1 && col_played == 1)
                    {
                        choice = rnd.Next(4);
                        switch (choice)
                        {
                            case 0:
                                row = 0;
                                column = 0;
                                break;

                            case 1:
                                row = 0;
                                column = 2;
                                break;

                            case 2:
                                row = 2;
                                column = 0;
                                break;

                            default:
                                row = 2;
                                column = 2;
                                break;
                        }
                    }
                    //Choose the centre square if opponent chose a corner
                    else if (corners.Contains((row_played, col_played)))
                    {
                        row = 1;
                        column = 1;
                    }
                    //Choose the centre square if opponent chose an edge
                    else if (edges.Contains((row_played, col_played)))
                    {
                        row = 1;
                        column = 1;
                    }

                    break;

                case 2:
                    //identify moves played so far - computer took move 0; player, move 1
                    comp_row = moves[0].Item1;
                    comp_col = moves[0].Item2;

                    row_played = moves[1].Item1;
                    col_played = moves[1].Item2;

                    //assign next move to the opposite corner if player took middle square
                    if ((row_played, col_played) == (1, 1))
                    {

                        row = (comp_row == 0) ? 2 : 0;

                        column = (comp_col == 0) ? 2 : 0;

                    }
                    //assign next move for if player took a corner - if both corners on one side are taken, assign the opposite corner to comp opening move
                    //if player took opposite corner, assign at random one of the other two corners
                    else if (corners.Contains((row_played, col_played)))
                    {
                        if (comp_row == 0 && comp_col == 0)
                        {
                            if (row_played == 2 && col_played == 2)
                            {
                                choice = rnd.Next(2);
                                if (choice == 0)
                                {
                                    row = 0;
                                    column = 2;
                                }
                                else
                                {
                                    row = 2;
                                    column = 0;
                                }
                            }
                            else
                            {
                                row = 2;
                                column = 2;
                            }
                        }
                        else if (comp_row == 2 && comp_col == 2)
                        {
                            if (row_played == 0 && col_played == 0)
                            {
                                choice = rnd.Next(2);
                                if (choice == 0)
                                {
                                    row = 0;
                                    column = 2;
                                }
                                else
                                {
                                    row = 2;
                                    column = 0;
                                }
                            }
                            else
                            {
                                row = 0;
                                column = 0;
                            }
                        }
                        else if (comp_row == 0 && comp_col == 2)
                        {
                            if (row_played == 2 && col_played == 0)
                            {
                                choice = rnd.Next(2);
                                if (choice == 0)
                                {
                                    row = 0;
                                    column = 0;
                                }
                                else
                                {
                                    row = 2;
                                    column = 2;
                                }
                            }
                            else
                            {
                                row = 2;
                                column = 0;
                            }
                        }
                        else if (comp_row == 2 && comp_col == 0)
                        {
                            if (row_played == 0 && col_played == 2)
                            {
                                choice = rnd.Next(2);
                                if (choice == 0)
                                {
                                    row = 0;
                                    column = 0;
                                }
                                else
                                {
                                    row = 2;
                                    column = 2;
                                }
                            }
                            else
                            {
                                row = 0;
                                column = 2;
                            }
                        }
                    }
                    //if player chose an edge space, it will either be adjacent to the opening computer corner or not
                    //if it is adjacent, choose the other corner that shares a row or column with the computer opening move, but not the player move
                    //if it is not adjacent, choose the corner that shares a row or column with the computer opening move and the player move
                    else if (edges.Contains((row_played, col_played)))
                    {
                        //check if the player edge is adjacent to the computer corner
                        if (row_played == comp_row || col_played == comp_col)
                        {
                            //if row_played is 1, then avoid the column of col_played
                            if (row_played == 1)
                            {
                                if (col_played == 0)
                                {
                                    column = 2;
                                }
                                else
                                {
                                    column = 0;
                                }

                                //then match the row to the row of the first computer move
                                row = comp_row;
                            }
                            //otherwise avoid the row of row_played
                            else if (col_played == 1)
                            {
                                if (row_played == 0)
                                {
                                    row = 2;
                                }
                                else
                                {
                                    row = 0;
                                }

                                //then match the column to the column of the first computer move
                                column = comp_col;
                            }
                        }
                        //if the two moves are not adjacent
                        else
                        {
                            if (row_played == 1)
                            {
                                //match the column to the non-adjacent player move
                                column = col_played;

                                //match the row to the computer opening move
                                row = comp_row;
                            }
                            else if (col_played == 1)
                            {
                                //match the row to the non-adjacent player move
                                row = row_played;

                                //match the column to the computer opening move
                                column = comp_col;
                            }
                        }
                    }
                    
                    break;

                //from this point on, since a player has taken two moves, it is possible that a winning move has been set up
                //for each future case, first use method to check if there is a possible winning move to play or block before considering which moves have been played
                case 3:
                    //in this case, the player has had two moves and the computer has had one move
                    possible_move = FindWinningMove(board, player_start);

                    if (possible_move.Item1 == -1)
                    {
                        row_played = moves[0].Item1;
                        col_played = moves[0].Item2;

                        comp_row = moves[1].Item1;
                        comp_col = moves[1].Item2;

                        //if the player's opening move was in the centre, then the computer chose a random corner
                        //if the player then chose any square except for the opposite corner (blocking their own line of three), they would have set up a winning line
                        //so, if no winning move was found to block, then the player must have taken the corner opposite the computer
                        //now the computer can choose another random corner
                        if ((row_played, col_played) == (1, 1))
                        {
                            choice = rnd.Next(2);

                            if ((comp_row, comp_col) == (0, 0) || (comp_row, comp_col) == (2, 2))
                            {
                                if (choice == 0)
                                {
                                    row = 0;
                                    column = 2;
                                }
                                else
                                {
                                    row = 2;
                                    column = 0;
                                }
                            }
                            else 
                            {
                                if (choice == 0)
                                {
                                    row = 0;
                                    column = 0;
                                }
                                else
                                {
                                    row = 2;
                                    column = 2;
                                }
                            }

                        }
                        //if the player's first move was a corner, then the computer took the middle square
                        //if the player then took an edge or corner in the same row or column as their opening move, a winning move would have been found
                        //so here, the player could have played the opposite corner (so all three moves lie on one diagonal)
                        //or they could have played one of the two edges that don't share a row or column with the opening move
                        else if (corners.Contains((row_played, col_played)))
                        {
                            //if the player's second move is also in a corner, then we must have a line of three across a diagonal for the first three moves
                            //in this case, the computer must play an edge - due to symmetry, this can be chosen randomly
                            if (corners.Contains((moves[2].Item1, moves[2].Item2)))
                            {
                                choice = rnd.Next(4);

                                switch (choice)
                                {
                                    case 0:
                                        row = 0;
                                        column = 1;
                                        break;

                                    case 1:
                                        row = 1;
                                        column = 0;
                                        break;

                                    case 2:
                                        row = 1;
                                        column = 2;
                                        break;

                                    default:
                                        row = 2;
                                        column = 1;
                                        break;
                                }
                            }
                            //otherwise the player must have played one of two edges that do not share a row or column with the opening move
                            //for this edge move, either the row or column value will be 1 (to make sure it shares a row or column with the middle square)
                            //to force the next move for the player, the computer will choose the corner that is adjacent to the player's last move
                            //but not the corner that is opposite the player's original move - this will share a co-ordinate with each of the player's two moves
                            //but it will not share the 1 with the player's second move
                            else
                            {
                                //if the edge move is in the middle row, the computer should play in the same column as this move
                                //and so it should play in the same row as the player's first move
                                if (moves[2].Item1 == 1)
                                {
                                    column = moves[2].Item2;
                                    row = moves[0].Item1;
                                }
                                //otherwise the edge move is in the middle column, then the computer should play in the same row
                                else
                                {
                                    row = moves[2].Item1;
                                    column = moves[0].Item2;
                                }
                            }
                        }
                        //finally, if the player's opening move was an edge move, the computer then played in the middle square
                        //1 - if the player then choses one of the adjacent corners, a winning move would have been found and blocked
                        //2 - if the player then choses the opposite edge to complete a line or row, the computer can choose any corner due to symmetry
                        //3 - if the player then choses one of the other two edges (i.e. not opposite the first move), the computer can choose the corner between these
                        //4 - and if the player then choses one of the non-adjacent two corners, the computer can choose the corner that shares a row or column with each
                        //of the player's moves to block off possible moves and force the next moves - start with the edge piece, non-middle row or column
                        else if (edges.Contains((row_played, col_played)))
                        {
                            //check for one of the cases where the player chooses a corner - cases 1 and 4
                            if (corners.Contains((moves[2].Item1, moves[2].Item2)))
                            {
                                //no need to check if the corner shares a row or column with the first move (edge) - case 1
                                //if the latest move is a corner, it will fall into case 4
                                if (row_played == 1)
                                {
                                    //the original move was in the middle row, so match the original column and the corner move row
                                    column = col_played;
                                    row = moves[2].Item1;
                                }
                                else
                                {
                                    row = row_played;
                                    column = moves[2].Item2;
                                }

                            }
                            //check for the cases where the player choose another edge - cases 2 and 3
                            else
                            {
                                //for case 2, the rows for the players two moves are the same, or the columns are the same
                                //in this case, choose a random corner
                                if (row_played == moves[2].Item1 || col_played == moves[2].Item2)
                                {
                                    choice = rnd.Next(4);

                                    switch (choice)
                                    {
                                        case 0:
                                            row = 0;
                                            column = 0;
                                            break;

                                        case 1:
                                            row = 0;
                                            column = 2;
                                            break;

                                        case 2:
                                            row = 2;
                                            column = 0;
                                            break;

                                        default:
                                            row = 2;
                                            column = 2;
                                            break;
                                    }
                                }

                                //otherwise, look at case 3
                                //for each edge, one co-ordinate will be 1 - for the middle row or column - choose the other to find the correct corner
                                else
                                {
                                    if (row_played == 1)
                                    {
                                        column = col_played;
                                        row = moves[2].Item1;
                                    }
                                    else if (col_played == 1)
                                    {
                                        row = row_played;
                                        column = moves[2].Item2;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        row = possible_move.Item1;
                        column = possible_move.Item2;
                    }
                    break;

                case 4:
                    //four moves completed - the computer started by choosing one corner
                    //log player move 1 and computer move 1 to help track the game so far
                    row_played = moves[1].Item1;
                    col_played = moves[1].Item2;

                    comp_row = moves[0].Item1;
                    comp_col = moves[0].Item2;

                    //check for a winning move or a move to block a potential winning move
                    possible_move = FindWinningMove(board, player_start);

                    //if no winning move found or move blocked
                    if (possible_move.Item1 == -1)
                    {
                        //if the player's first move was choosing the middle square, computer took the opposite corner to complete the diagonal (XOX)
                        //in this case, whereever the player put their second 'O', the computer is forced to block a possible winning move
                        //so, this case is covered

                        //if the player's first move was in a corner, there are two cases
                        //1 - if the player chose a corner in the same row or column, the computer chose the opposite corner to its original move
                        //this then meant the player's second move had to be in the middle, forcing a computer move to block (or to win if not)
                        //so, this case is covered

                        //2 - if the player chose the corner opposite the computer's starting move, the computer then chose a second corner
                        //this corner was either in the same row or column as the first corner chosen
                        //this means that the player either has to block this, or the computer will find this winning move
                        //if the move is blocked, the computer needs to fill the final corner to win on the next move

                        if (corners.Contains((row_played, col_played)))
                        {
                            //case 2 - fill the final corner
                            for (int i = 0; i < 3; i += 2)
                            {
                                for (int j = 0; j < 3; j += 2)
                                {
                                    if (board[i, j] == ' ')
                                    {
                                        row = i;
                                        column = j;
                                    }
                                }
                            }
                        }

                        //if the player's first move was choosing an edge, whether or not this was adjacent to the computer corner
                        //the computer chose another corner to have one corner adjacent to the player edge
                        //the other computer corner was then in the same row or column, but not with the player edge
                        //this means that the player is forced to take the edge in between these corners (or lose)
                        //then the computer can choose one of the two other corners that does not share a row or column with the player moves
                        //this creates two possible computer winning moves which will be found by the find winning move method

                        else if (edges.Contains((row_played, col_played)))
                        {
                            //find the row that does not have a player move in
                            //the total of the three rows is (0 + 1 + 2 =) 3
                            //use this to find the row that does not have a player move in (e.g. total of 3 => choose row 0)
                            if (row_played + moves[3].Item1 == 3)
                            {
                                row = 0;
                            }
                            else if (row_played + moves[3].Item1 == 2)
                            {
                                row = 1;
                            }
                            else if (row_played + moves[3].Item1 == 1)
                            {
                                row = 2;
                            }
                            //similiar calculations will reveal the empty column
                            if (col_played + moves[3].Item2 == 3)
                            {
                                column = 0;
                            }
                            else if (col_played + moves[3].Item2 == 2)
                            {
                                column = 1;
                            }
                            else if (col_played + moves[3].Item2 == 1)
                            {
                                column = 2;
                            }
                        }
                    }
                    //otherwise play the forced move
                    else
                    {
                        row = possible_move.Item1;
                        column = possible_move.Item2;
                    }
                    break;

                case 5:
                    //five moves have been completed, starting with the player who has made three
                    //the computer has made two moves
                    //first, find the opening moves to help inform the next steps
                    row_played = moves[0].Item1;
                    col_played = moves[0].Item2;

                    comp_row = moves[1].Item1;
                    comp_col = moves[1].Item2;

                    //check if there is a possible move to either win or to block a potential winning move
                    possible_move = FindWinningMove(board, player_start);

                    //if no winning move has been found, check the other possibilities
                    if (possible_move.Item1 == -1)
                    {
                        //if the opening move by the player was a corner, the computer then chose a middle square
                        //1 - if the player then chose the opposite corner to create a line (XOX), the computer then chose an edge
                        //the player would then have to block or the game is over, similarly for move 6, the computer qould then have to block
                        //this case will involve no choice or the game will end
                        //2 - if the player's second move was to choose one of the other corners, for move 4 the computer would have had to take the edge in between
                        //this then would leave a row of two, forcing the player to choose the opposite edge to block
                        //the computer can then pick one of the other two edges to force the player's next move
                        //3 - if the player chose an edge adjacent to their opening corner, then all subsequent moves will be forced to end in a draw
                        //the computer picks a corner to block the line of two, the player then choses the opposite corner to block this line of two (or loses)
                        //the computer then has to pick the edge in between these two - so this case is found by the winning move finder
                        //4 - if the player's second move is to chose a non-adjacent edge, the computer chose the corner next to it, also in the same row or column as the first move
                        //this will force the player to take the opposite corner or lose, and will mean the computer has to move to block the player
                        //so this will be covered by the find winning move
                        if (corners.Contains((row_played, col_played)))
                        {
                            //if the second move was a corner, see case 2
                            //case 1 will have been covered by finding a possible winning move
                            if (corners.Contains((moves[2].Item1, moves[2].Item2)))
                            {
                                //the two edges chosen so far will either share the middle row or column (moves 4 and 5)
                                //if they share the middle row, then computer can choose one the two edges in the middle column, and vice versa
                                if (moves[3].Item1 == 1)
                                {
                                    //choose randomly from the edges on the middle column
                                    choice = rnd.Next(2);
                                    if (choice == 0)
                                    {
                                        row = 0;
                                        column = 1;
                                    }
                                    else
                                    {
                                        row = 2;
                                        column = 1;
                                    }
                                }
                                else if (moves[3].Item2 == 1)
                                {
                                    //choose randomly from the edges on the middle row
                                    choice = rnd.Next(2);
                                    if (choice == 0)
                                    {
                                        row = 1;
                                        column = 0;
                                    }
                                    else
                                    {
                                        row = 1;
                                        column = 2;
                                    }
                                }
                            }
                        }

                        //if the player's opening move was the middle square, the computer opened by choosing a random corner
                        //1 - if the player then chose a corner that shared a row or column with the computer's corner (i.e. not opposite),
                        //the computer would then be forced into playing the other non-opposite corner (opposite the player's corner to block the player's move)
                        //the player would then have to take the edge between the two computer corners or lose, forcing the computer to block by taking the opposite edge
                        //all these moves would be covered by the find winning move method
                        //2 - if the player instead chose the corner opposite the computer move, the computer then chose one of the other two corners
                        //the player would have to chose the edge in between the two computer corners or lose
                        //the computer would then have to chose the opposite edge to block the line of two through the middle
                        //these moves would be covered by the find winning move method
                        //3 - if the player's second move was to choose one of the two edge spaces adjacent to the computer corner,
                        //the computer would have been forced to play the opposite edge to block the line through the middle
                        //unless the player then took the corner opposite the opening computer move, the computer would be forced to block another line through the middle
                        //so, assuming no winning move was found to block, the player must have chosen the corner opposite the computer opening move
                        //so, the computer needs to play in the corner that shares a row or column with each of the two computer moves played so far
                        //this is the only way to set up a potential winning move for the computer
                        //4 - if the player's second move was to choose one of the two edge spaces not adjacent to the computer corner,
                        //the computer's second move is forced - it takes the opposite edge, adjacent to its opening move
                        //the player is then forced to take the other corner adjacent to the computer's edge move (or lose)
                        //this creates a potential winning diagonal for the player, which the computer blocks
                        //so, case 4 is covered by the find winning move method
                        
                        else if (row_played == 1 && col_played == 1)
                        {
                            //case 3 - look at the second computer move (an edge space) and take the non-middle (!= 1) co-ordinate - take the other from move one
                            if (moves[3].Item1 == 1)
                            {
                                column = moves[3].Item2;
                                row = comp_row;
                            }
                            else if (moves[3].Item2 == 1)
                            {
                                row = moves[3].Item1;
                                column = comp_col;
                            }
                        }

                        //if the player's opening move was an edge space, the computer took the middle square
                        //1 - if the player then played a corner adjacent to their opening edge move, the computer was forced to block this with the other adjacent corner
                        //this created a diagonal for the computer that the player had to block (or lose)
                        //which in turn gave the player two corners on one side, and the computer chooses the edge space in between
                        //so case 1 is covered by find winning move
                        //2 - if the player's second move was the opposite edge to their first (creating a OXO line), the computer then chose a random corner
                        //the player then had to take the opposite corner to block a winning diagonal (or lose)
                        //this forces the computer to block the potential winning row or column, setting up two possible winning moves
                        //case 2 is covered by find winning move
                        //3 - if the player's second move was to choose another edge but not opposite, the computer chose the corner in between the player's two edges
                        //the computer can now choose either of the remaining two corners to force the player into taking the other corner and a draw
                        //so, look at the computer's opening move and choose randomly one of the two non-opposite corners
                        //4 - if the player's second move was to choose a corner not adjacent to their opening move,
                        //the computer then chose the corner that shared a row or column with each of the player's two moves
                        //this forced the player to chose the opposite corner to block this, creating a possible winning row or column
                        //so, the computer is forced to block this by taking the edge space in between
                        //case 4 is covered by the find winning move method

                        else if (edges.Contains((row_played, col_played)))
                        {
                            //case 3 - player move 2 does not share a row or column with player move 1
                            //computer chooses randomly a corner that shares either a row or column with its opening move
                            if (moves[2].Item1 != row_played && moves[2].Item2 != col_played)
                            {
                                choice = rnd.Next(2);

                                if (choice == 0)
                                {
                                    //row the same as second move, but column is different for a non-opposite corner
                                    row = moves[3].Item1;
                                    column = (moves[3].Item2 == 0) ? 2 : 0;
                                }
                                else
                                {
                                    //column the same as second move, but row is different for a non-opposite corner
                                    column = moves[3].Item2;
                                    row = (moves[3].Item1 == 0) ? 2 : 0;
                                }
                            }
                        }

                    }
                    //if not, play the forced move
                    else
                    {
                        row = possible_move.Item1;
                        column = possible_move.Item2;
                    }
                    break;

                case 6:
                    //in this case, the computer opened by playing a random corner
                    //the computer and player have now had three moves each - there are only three empty squares
                    //identify any possible winning move or an opponent winning move to block
                    possible_move = FindWinningMove(board, player_start);

                    //identify moves played so far - computer took move 0; player, move 1
                    comp_row = moves[0].Item1;
                    comp_col = moves[0].Item2;

                    row_played = moves[1].Item1;
                    col_played = moves[1].Item2;

                    //if no winning move is found, consider which moves have been played already
                    if (possible_move.Item1 == -1)
                    {
                        //if the player's first move was to take the centre square, the computer then took the opposite corner to its opening move (creating a XOX diagonal)
                        //1 - if the player then chose an edge, every move from then on requires blocking a possible win until all spaces are filled
                        //in this case, the find winning move method will complete all the computer moves until the game is finished
                        //2 - if the player had chosen a corner instead, the computer would be forced to block the player's possible diagonal
                        //this would create two possible winning moves for the computer (as it would have filled three of the corners)
                        //so, the find winning move method would complete each move until the computer won
                        //so, in the case that the player's first move was the centre square, the find winning move method then completes the game

                        //alternatively, the player's first move could have been to take a corner (either opposite the computer corner or sharing a row/column)
                        //1 - the player chose a non-opposite corner and the computer responded by taking the opposite corner (to its opening move)
                        //from this point on, all moves are forced to avoid a loss until the computer wins
                        //so, the find winning move method covers all of these
                        //2 - the player choses the opposite corner to the opening move and the computer chose one of the other corners at random
                        //the player then had to take an edge between the two computer corners (or lose)
                        //the computer then took a third corner, setting up two possible winning moves
                        //so, again, the find winning move method will complete the game

                        //finally, the player's first move could have been to take an edge space (either adjacent to the opening move or not)
                        //whether the player starts adjacent to the computer corner or not, the computer can then set up a winning position (using three corners)
                        //and by this point, all moves are covered by the find winning move method
                        
                        //so, no new moves are needed for these cases - all are covered by the find winning move method to either force a draw or a win
                    }
                    //otherwise play the winning move or block the opponent's winning move
                    else
                    {
                        row = possible_move.Item1;
                        column = possible_move.Item2;
                    }
                    break;

                case 7:

                    //use method to check if there is a winning move, or an essential move to stop an opponent win
                    possible_move = FindWinningMove(board, player_start);

                    //if no move was found, assign a random move from the two possible moves - neither move can lead to a win and the game will end in a draw
                    if (possible_move.Item1 == -1)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (board[i, j] == ' ')
                                {
                                    row = i;
                                    column = j;
                                    
                                }
                            }
                        }
                    }
                    //if a winning move was found, move to win or block an opponent win
                    else
                    {
                        row = possible_move.Item1;
                        column = possible_move.Item2;
                    }
                    break;

                case 8:
                    //check each space to find the one empty space and fill it
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == ' ')
                            {
                                row = i;
                                column = j;
                            }
                        }
                    }
                    break;

                default:
                    break;
            }


            //adds correct counter to the board based on row and column selected
            board[row, column] = (player_start) ? 'O' : 'X';

            //return the space chosen to add to the list of moves so far
            return Tuple.Create(row, column);
        }
        
        //method to play a two player game - alternate moves between two players
        public static void PlayGameTwoPlayer(char[,] board)
        {

            //assume that the game is not over nor a draw; choose a start character and ensure that player2 has a different character to player1
            bool game_over = false;
            bool draw = false;
            bool player_start = ChooseStartCharacterTwoPlayer();
            bool player2_start = (player_start) ? false : true;
            bool player_move = false;

            //if player1 does not start, give player2 the opening move
            if (!player_start)
            {
                PlayerMove(board, player2_start);
                PrintBoard(board);
                //record who took the last move - player 1 or not - for the game over conditions
                player_move = false;
            }

            //loop through moves until the game over conditions are met - after each move check if there is a winner
            while (!game_over)
            {
                PlayerMove(board, player_start);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                //after each move, check if the board is full, ending the game as a draw
                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

                if (!game_over)
                {
                    PlayerMove(board, player2_start);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            //when the game over conditions are met, declare the result
            GameOverTwoPlayer(player_move, draw);
        }

        //a variation on play game two player but with a random choice of character
        public static void PlayGameTwoPlayerRandom(char[,] board)
        {
            Console.WriteLine("The computer is choosing the character for Player One.");
            
            bool game_over = false;
            bool draw = false;
            bool player_start = RandomChooseStart();
            bool player2_start = (player_start) ? false : true;
            bool player_move = false;

            if (player_start)
            {
                Console.WriteLine("Player Two, you are O.");
            }
            else
            {
                Console.WriteLine("Player Two, you are X.");
            }

            if (!player_start)
            {
                PlayerMove(board, player2_start);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                PlayerMove(board, player_start);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

                if (!game_over)
                {
                    PlayerMove(board, player2_start);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOverTwoPlayer(player_move, draw);
        }

        //a variation of play game that alternates between the human player and an easy computer move
        public static void PlayGameCompEasy(char[,] board)
        {

            bool game_over = false;
            bool draw = false;
            bool player_start = ChooseStartCharacter();
            bool player_move = false;

            if (!player_start)
            {
                ComputerMoveEasy(board, player_start);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                PlayerMove(board, player_start);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                if (!game_over)
                {
                    ComputerMoveEasy(board, player_start);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOver(player_move, draw);
        }

        //a random choice of who starts and an easy computer move
        public static void PlayGameCompEasyRandom(char[,] board)
        {

            bool game_over = false;
            bool draw = false;
            bool player_start = RandomChooseStart();
            bool player_move = false;

            if (!player_start)
            {
                ComputerMoveEasy(board, player_start);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                PlayerMove(board, player_start);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                if (!game_over)
                {
                    ComputerMoveEasy(board, player_start);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOver(player_move, draw);
        }

        //a variation of play game with a medium computer move
        public static void PlayGameCompMedium(char[,] board)
        {

            List<Tuple<int, int>> moves = new();

            Tuple<int, int> latest_move = Tuple.Create(0, 0);

            bool game_over = false;
            bool draw = false;
            bool player_start = ChooseStartCharacter();
            bool player_move = false;

            if (!player_start)
            {

                latest_move = ComputerMoveMedium(board, player_start, moves);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                latest_move = PlayerMove(board, player_start);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

                if (!game_over)
                {
                    latest_move = ComputerMoveMedium(board, player_start, moves);
                    moves.Add(latest_move);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOver(player_move, draw);
        }
       
        //a variation of play game with a medium computer move and a random choice of start player
        public static void PlayGameCompMediumRandom(char[,] board)
        {

            List<Tuple<int, int>> moves = new();

            Tuple<int, int> latest_move = Tuple.Create(0, 0);

            bool game_over = false;
            bool draw = false;
            bool player_start = RandomChooseStart();
            bool player_move = false;

            if (!player_start)
            {

                latest_move = ComputerMoveMedium(board, player_start, moves);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                latest_move = PlayerMove(board, player_start);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

                if (!game_over)
                {
                    latest_move = ComputerMoveMedium(board, player_start, moves);
                    moves.Add(latest_move);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOver(player_move, draw);
        }

        //a variation of play game with a hard computer move
        public static void PlayGameCompHard(char[,] board)
        {
            List<Tuple<int, int>> moves = new();

            Tuple<int, int> latest_move = Tuple.Create(0, 0);

            bool game_over = false;
            bool draw = false;
            bool player_start = ChooseStartCharacter();
            bool player_move = false;

            if (!player_start)
            {
                latest_move = ComputerMoveHard(board, player_start, moves);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                latest_move = PlayerMove(board, player_start);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

                if (!game_over)
                {
                    latest_move = ComputerMoveHard(board, player_start, moves);
                    moves.Add(latest_move);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOver(player_move, draw);
        }

        //a variation of play game with a hard computer move and a random character choice
        public static void PlayGameCompHardRandom(char[,] board)
        {
            List<Tuple<int, int>> moves = new();

            Tuple<int, int> latest_move = Tuple.Create(0, 0);

            bool game_over = false;
            bool draw = false;
            bool player_start = RandomChooseStart();
            bool player_move = false;

            if (!player_start)
            {
                latest_move = ComputerMoveHard(board, player_start, moves);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
            }

            while (!game_over)
            {
                latest_move = PlayerMove(board, player_start);
                moves.Add(latest_move);
                PrintBoard(board);
                player_move = true;
                game_over = CheckWin(board);

                int moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

                if (!game_over)
                {
                    latest_move = ComputerMoveHard(board, player_start, moves);
                    moves.Add(latest_move);
                    PrintBoard(board);
                    player_move = false;
                    game_over = CheckWin(board);
                }

                moves_completed = 0;
                foreach (char element in board)
                {
                    if (element != ' ')
                    {
                        moves_completed++;
                    }
                }
                if (moves_completed == 9 && !game_over)
                {
                    game_over = true;
                    draw = true;
                }

            }

            GameOver(player_move, draw);
        }

    }
}


