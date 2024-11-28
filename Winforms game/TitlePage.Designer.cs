namespace Noughts_and_Crosses_game
{
    partial class TitlePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitlePage));
            titleTitle = new Label();
            startButton = new Button();
            titlePanel = new Panel();
            titlePicture = new PictureBox();
            choosePanel = new Panel();
            chooseButtonRandom = new Button();
            chooseButtonO = new Button();
            chooseTitle = new Label();
            chooseInstructionsLabel = new Label();
            choosePicture = new PictureBox();
            chooseButtonX = new Button();
            playingPanel = new Panel();
            resetButton = new Button();
            counter22 = new PictureBox();
            counter21 = new PictureBox();
            counter20 = new PictureBox();
            counter12 = new PictureBox();
            counter11 = new PictureBox();
            counter10 = new PictureBox();
            counter02 = new PictureBox();
            counter01 = new PictureBox();
            counter00 = new PictureBox();
            playingSquare22 = new Button();
            playingSquare12 = new Button();
            playingSquare21 = new Button();
            playingSquare20 = new Button();
            playingSquare10 = new Button();
            playingSquare11 = new Button();
            playingSquare02 = new Button();
            playingSquare01 = new Button();
            playingSquare00 = new Button();
            playingScreen = new TextBox();
            playingBoardPicture = new PictureBox();
            playingTitle = new Label();
            playingInstructionsLabel = new Label();
            opponentPanel = new Panel();
            opponentButtonComputer = new Button();
            opponentInstructionsLabel = new Label();
            opponentPicture = new PictureBox();
            opponentButtonPlayer = new Button();
            opponentTitle = new Label();
            difficultyPanel = new Panel();
            difficultyButtonHard = new Button();
            difficultyButtonMedium = new Button();
            difficultyTitle = new Label();
            difficultyInstructionsLabel = new Label();
            difficultyPicture = new PictureBox();
            difficultyButtonEasy = new Button();
            loadingPanel = new Panel();
            loadingTitle = new Label();
            loadingTimer = new System.Windows.Forms.Timer(components);
            resetTimer = new System.Windows.Forms.Timer(components);
            computerTimer = new System.Windows.Forms.Timer(components);
            computerStartsTimer = new System.Windows.Forms.Timer(components);
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titlePicture).BeginInit();
            choosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)choosePicture).BeginInit();
            playingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)counter22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counter00).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playingBoardPicture).BeginInit();
            opponentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)opponentPicture).BeginInit();
            difficultyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)difficultyPicture).BeginInit();
            loadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleTitle
            // 
            titleTitle.AutoSize = true;
            titleTitle.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTitle.ForeColor = Color.FromArgb(255, 128, 0);
            titleTitle.Location = new Point(35, 40);
            titleTitle.Name = "titleTitle";
            titleTitle.Size = new Size(428, 46);
            titleTitle.TabIndex = 7;
            titleTitle.Text = "Noughts and Crosses";
            // 
            // startButton
            // 
            startButton.BackColor = Color.LightGray;
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startButton.Location = new Point(155, 500);
            startButton.Name = "startButton";
            startButton.Size = new Size(160, 70);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.Blue;
            titlePanel.Controls.Add(titlePicture);
            titlePanel.Controls.Add(titleTitle);
            titlePanel.Controls.Add(startButton);
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(500, 640);
            titlePanel.TabIndex = 8;
            // 
            // titlePicture
            // 
            titlePicture.BorderStyle = BorderStyle.Fixed3D;
            titlePicture.Image = (Image)resources.GetObject("titlePicture.Image");
            titlePicture.Location = new Point(52, 123);
            titlePicture.Name = "titlePicture";
            titlePicture.Size = new Size(387, 351);
            titlePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            titlePicture.TabIndex = 8;
            titlePicture.TabStop = false;
            // 
            // choosePanel
            // 
            choosePanel.BackColor = Color.Blue;
            choosePanel.Controls.Add(chooseButtonRandom);
            choosePanel.Controls.Add(chooseButtonO);
            choosePanel.Controls.Add(chooseTitle);
            choosePanel.Controls.Add(chooseInstructionsLabel);
            choosePanel.Controls.Add(choosePicture);
            choosePanel.Controls.Add(chooseButtonX);
            choosePanel.Location = new Point(0, 0);
            choosePanel.Name = "choosePanel";
            choosePanel.Size = new Size(500, 640);
            choosePanel.TabIndex = 11;
            // 
            // chooseButtonRandom
            // 
            chooseButtonRandom.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseButtonRandom.Location = new Point(325, 500);
            chooseButtonRandom.Name = "chooseButtonRandom";
            chooseButtonRandom.Size = new Size(130, 70);
            chooseButtonRandom.TabIndex = 17;
            chooseButtonRandom.Text = "Random";
            chooseButtonRandom.UseVisualStyleBackColor = true;
            chooseButtonRandom.Click += chooseButtonRandom_Click;
            // 
            // chooseButtonO
            // 
            chooseButtonO.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseButtonO.Location = new Point(185, 500);
            chooseButtonO.Name = "chooseButtonO";
            chooseButtonO.Size = new Size(130, 70);
            chooseButtonO.TabIndex = 16;
            chooseButtonO.Text = "O";
            chooseButtonO.UseVisualStyleBackColor = true;
            chooseButtonO.Click += chooseButtonO_Click;
            // 
            // chooseTitle
            // 
            chooseTitle.AutoSize = true;
            chooseTitle.BackColor = Color.Blue;
            chooseTitle.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseTitle.ForeColor = Color.FromArgb(255, 128, 0);
            chooseTitle.Location = new Point(35, 40);
            chooseTitle.Name = "chooseTitle";
            chooseTitle.Size = new Size(428, 46);
            chooseTitle.TabIndex = 8;
            chooseTitle.Text = "Noughts and Crosses";
            // 
            // chooseInstructionsLabel
            // 
            chooseInstructionsLabel.AutoSize = true;
            chooseInstructionsLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseInstructionsLabel.ForeColor = Color.FromArgb(255, 128, 0);
            chooseInstructionsLabel.Location = new Point(100, 403);
            chooseInstructionsLabel.Name = "chooseInstructionsLabel";
            chooseInstructionsLabel.Size = new Size(307, 84);
            chooseInstructionsLabel.TabIndex = 15;
            chooseInstructionsLabel.Text = "Choose your character:\r\nX starts, O goes second.";
            chooseInstructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // choosePicture
            // 
            choosePicture.BorderStyle = BorderStyle.Fixed3D;
            choosePicture.Image = (Image)resources.GetObject("choosePicture.Image");
            choosePicture.Location = new Point(100, 100);
            choosePicture.Name = "choosePicture";
            choosePicture.Size = new Size(300, 300);
            choosePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            choosePicture.TabIndex = 10;
            choosePicture.TabStop = false;
            // 
            // chooseButtonX
            // 
            chooseButtonX.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseButtonX.Location = new Point(45, 500);
            chooseButtonX.Name = "chooseButtonX";
            chooseButtonX.Size = new Size(130, 70);
            chooseButtonX.TabIndex = 1;
            chooseButtonX.Text = "X";
            chooseButtonX.UseVisualStyleBackColor = true;
            chooseButtonX.Click += chooseButtonX_Click;
            // 
            // playingPanel
            // 
            playingPanel.BackColor = Color.Blue;
            playingPanel.Controls.Add(resetButton);
            playingPanel.Controls.Add(counter22);
            playingPanel.Controls.Add(counter21);
            playingPanel.Controls.Add(counter20);
            playingPanel.Controls.Add(counter12);
            playingPanel.Controls.Add(counter11);
            playingPanel.Controls.Add(counter10);
            playingPanel.Controls.Add(counter02);
            playingPanel.Controls.Add(counter01);
            playingPanel.Controls.Add(counter00);
            playingPanel.Controls.Add(playingSquare22);
            playingPanel.Controls.Add(playingSquare12);
            playingPanel.Controls.Add(playingSquare21);
            playingPanel.Controls.Add(playingSquare20);
            playingPanel.Controls.Add(playingSquare10);
            playingPanel.Controls.Add(playingSquare11);
            playingPanel.Controls.Add(playingSquare02);
            playingPanel.Controls.Add(playingSquare01);
            playingPanel.Controls.Add(playingSquare00);
            playingPanel.Controls.Add(playingScreen);
            playingPanel.Controls.Add(playingBoardPicture);
            playingPanel.Controls.Add(playingTitle);
            playingPanel.Controls.Add(playingInstructionsLabel);
            playingPanel.Location = new Point(0, 0);
            playingPanel.Name = "playingPanel";
            playingPanel.Size = new Size(500, 640);
            playingPanel.TabIndex = 12;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.LightGray;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(155, 319);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(160, 70);
            resetButton.TabIndex = 35;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // counter22
            // 
            counter22.BackColor = Color.White;
            counter22.Image = Properties.Resources.blank_counter;
            counter22.Location = new Point(329, 438);
            counter22.Name = "counter22";
            counter22.Size = new Size(110, 110);
            counter22.SizeMode = PictureBoxSizeMode.StretchImage;
            counter22.TabIndex = 34;
            counter22.TabStop = false;
            // 
            // counter21
            // 
            counter21.BackColor = Color.White;
            counter21.Image = Properties.Resources.blank_counter;
            counter21.Location = new Point(181, 438);
            counter21.Name = "counter21";
            counter21.Size = new Size(110, 110);
            counter21.SizeMode = PictureBoxSizeMode.StretchImage;
            counter21.TabIndex = 33;
            counter21.TabStop = false;
            // 
            // counter20
            // 
            counter20.BackColor = Color.White;
            counter20.Image = Properties.Resources.blank_counter;
            counter20.Location = new Point(53, 438);
            counter20.Name = "counter20";
            counter20.Size = new Size(110, 110);
            counter20.SizeMode = PictureBoxSizeMode.StretchImage;
            counter20.TabIndex = 32;
            counter20.TabStop = false;
            // 
            // counter12
            // 
            counter12.BackColor = Color.White;
            counter12.Image = Properties.Resources.blank_counter;
            counter12.Location = new Point(329, 300);
            counter12.Name = "counter12";
            counter12.Size = new Size(110, 110);
            counter12.SizeMode = PictureBoxSizeMode.StretchImage;
            counter12.TabIndex = 31;
            counter12.TabStop = false;
            // 
            // counter11
            // 
            counter11.BackColor = Color.White;
            counter11.Image = Properties.Resources.blank_counter;
            counter11.Location = new Point(185, 300);
            counter11.Name = "counter11";
            counter11.Size = new Size(110, 110);
            counter11.SizeMode = PictureBoxSizeMode.StretchImage;
            counter11.TabIndex = 30;
            counter11.TabStop = false;
            // 
            // counter10
            // 
            counter10.BackColor = Color.White;
            counter10.Image = Properties.Resources.blank_counter;
            counter10.Location = new Point(53, 300);
            counter10.Name = "counter10";
            counter10.Size = new Size(110, 110);
            counter10.SizeMode = PictureBoxSizeMode.StretchImage;
            counter10.TabIndex = 29;
            counter10.TabStop = false;
            // 
            // counter02
            // 
            counter02.BackColor = Color.White;
            counter02.Image = Properties.Resources.blank_counter;
            counter02.Location = new Point(329, 172);
            counter02.Name = "counter02";
            counter02.Size = new Size(110, 110);
            counter02.SizeMode = PictureBoxSizeMode.StretchImage;
            counter02.TabIndex = 28;
            counter02.TabStop = false;
            // 
            // counter01
            // 
            counter01.BackColor = Color.White;
            counter01.Image = Properties.Resources.blank_counter;
            counter01.Location = new Point(185, 170);
            counter01.Name = "counter01";
            counter01.Size = new Size(110, 110);
            counter01.SizeMode = PictureBoxSizeMode.StretchImage;
            counter01.TabIndex = 27;
            counter01.TabStop = false;
            // 
            // counter00
            // 
            counter00.BackColor = Color.White;
            counter00.Image = Properties.Resources.blank_counter;
            counter00.Location = new Point(52, 172);
            counter00.Name = "counter00";
            counter00.Size = new Size(110, 110);
            counter00.SizeMode = PictureBoxSizeMode.StretchImage;
            counter00.TabIndex = 26;
            counter00.TabStop = false;
            // 
            // playingSquare22
            // 
            playingSquare22.BackColor = Color.White;
            playingSquare22.FlatStyle = FlatStyle.Flat;
            playingSquare22.Location = new Point(312, 438);
            playingSquare22.Name = "playingSquare22";
            playingSquare22.Size = new Size(138, 132);
            playingSquare22.TabIndex = 25;
            playingSquare22.UseVisualStyleBackColor = false;
            playingSquare22.Click += playingSquare22_Click;
            // 
            // playingSquare12
            // 
            playingSquare12.BackColor = Color.White;
            playingSquare12.FlatStyle = FlatStyle.Flat;
            playingSquare12.Location = new Point(312, 290);
            playingSquare12.Name = "playingSquare12";
            playingSquare12.Size = new Size(138, 142);
            playingSquare12.TabIndex = 24;
            playingSquare12.UseVisualStyleBackColor = false;
            playingSquare12.Click += playingSquare12_Click;
            // 
            // playingSquare21
            // 
            playingSquare21.BackColor = Color.White;
            playingSquare21.FlatStyle = FlatStyle.Flat;
            playingSquare21.Location = new Point(169, 438);
            playingSquare21.Name = "playingSquare21";
            playingSquare21.Size = new Size(138, 132);
            playingSquare21.TabIndex = 23;
            playingSquare21.UseVisualStyleBackColor = false;
            playingSquare21.Click += playingSquare21_Click;
            // 
            // playingSquare20
            // 
            playingSquare20.BackColor = Color.White;
            playingSquare20.FlatStyle = FlatStyle.Flat;
            playingSquare20.Location = new Point(50, 438);
            playingSquare20.Name = "playingSquare20";
            playingSquare20.Size = new Size(113, 132);
            playingSquare20.TabIndex = 22;
            playingSquare20.UseVisualStyleBackColor = false;
            playingSquare20.Click += playingSquare20_Click;
            // 
            // playingSquare10
            // 
            playingSquare10.BackColor = Color.White;
            playingSquare10.FlatStyle = FlatStyle.Flat;
            playingSquare10.Location = new Point(50, 290);
            playingSquare10.Name = "playingSquare10";
            playingSquare10.Size = new Size(113, 142);
            playingSquare10.TabIndex = 21;
            playingSquare10.UseVisualStyleBackColor = false;
            playingSquare10.Click += playingSquare10_Click;
            // 
            // playingSquare11
            // 
            playingSquare11.BackColor = Color.White;
            playingSquare11.FlatStyle = FlatStyle.Flat;
            playingSquare11.Location = new Point(169, 290);
            playingSquare11.Name = "playingSquare11";
            playingSquare11.Size = new Size(138, 142);
            playingSquare11.TabIndex = 20;
            playingSquare11.UseVisualStyleBackColor = false;
            playingSquare11.Click += playingSquare11_Click;
            // 
            // playingSquare02
            // 
            playingSquare02.BackColor = Color.White;
            playingSquare02.FlatStyle = FlatStyle.Flat;
            playingSquare02.Location = new Point(312, 170);
            playingSquare02.Name = "playingSquare02";
            playingSquare02.Size = new Size(138, 114);
            playingSquare02.TabIndex = 19;
            playingSquare02.UseVisualStyleBackColor = false;
            playingSquare02.Click += playingSquare02_Click;
            // 
            // playingSquare01
            // 
            playingSquare01.BackColor = Color.White;
            playingSquare01.FlatStyle = FlatStyle.Flat;
            playingSquare01.Location = new Point(169, 170);
            playingSquare01.Name = "playingSquare01";
            playingSquare01.Size = new Size(138, 114);
            playingSquare01.TabIndex = 18;
            playingSquare01.UseVisualStyleBackColor = false;
            playingSquare01.Click += playingSquare01_Click;
            // 
            // playingSquare00
            // 
            playingSquare00.BackColor = Color.White;
            playingSquare00.FlatStyle = FlatStyle.Flat;
            playingSquare00.Location = new Point(50, 170);
            playingSquare00.Name = "playingSquare00";
            playingSquare00.Size = new Size(113, 114);
            playingSquare00.TabIndex = 17;
            playingSquare00.UseVisualStyleBackColor = false;
            playingSquare00.Click += playingSquare00_Click;
            // 
            // playingScreen
            // 
            playingScreen.BackColor = Color.FromArgb(224, 224, 224);
            playingScreen.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playingScreen.Location = new Point(50, 584);
            playingScreen.Name = "playingScreen";
            playingScreen.ReadOnly = true;
            playingScreen.Size = new Size(400, 45);
            playingScreen.TabIndex = 16;
            playingScreen.Text = "X to play first. Good luck!";
            playingScreen.TextAlign = HorizontalAlignment.Center;
            // 
            // playingBoardPicture
            // 
            playingBoardPicture.Image = (Image)resources.GetObject("playingBoardPicture.Image");
            playingBoardPicture.Location = new Point(50, 170);
            playingBoardPicture.Name = "playingBoardPicture";
            playingBoardPicture.Size = new Size(400, 400);
            playingBoardPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            playingBoardPicture.TabIndex = 15;
            playingBoardPicture.TabStop = false;
            // 
            // playingTitle
            // 
            playingTitle.AutoSize = true;
            playingTitle.BackColor = Color.Blue;
            playingTitle.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playingTitle.ForeColor = Color.FromArgb(255, 128, 0);
            playingTitle.Location = new Point(35, 40);
            playingTitle.Name = "playingTitle";
            playingTitle.Size = new Size(428, 46);
            playingTitle.TabIndex = 13;
            playingTitle.Text = "Noughts and Crosses";
            // 
            // playingInstructionsLabel
            // 
            playingInstructionsLabel.AutoSize = true;
            playingInstructionsLabel.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playingInstructionsLabel.ForeColor = Color.FromArgb(255, 128, 0);
            playingInstructionsLabel.Location = new Point(10, 95);
            playingInstructionsLabel.Name = "playingInstructionsLabel";
            playingInstructionsLabel.Size = new Size(488, 66);
            playingInstructionsLabel.TabIndex = 14;
            playingInstructionsLabel.Text = "Click on an empty square to place your counter.\r\nFirst to get three in a row wins!";
            playingInstructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // opponentPanel
            // 
            opponentPanel.BackColor = Color.Blue;
            opponentPanel.Controls.Add(opponentButtonComputer);
            opponentPanel.Controls.Add(opponentInstructionsLabel);
            opponentPanel.Controls.Add(opponentPicture);
            opponentPanel.Controls.Add(opponentButtonPlayer);
            opponentPanel.Controls.Add(opponentTitle);
            opponentPanel.Location = new Point(0, 0);
            opponentPanel.Name = "opponentPanel";
            opponentPanel.Size = new Size(500, 640);
            opponentPanel.TabIndex = 10;
            // 
            // opponentButtonComputer
            // 
            opponentButtonComputer.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opponentButtonComputer.Location = new Point(260, 500);
            opponentButtonComputer.Name = "opponentButtonComputer";
            opponentButtonComputer.Size = new Size(160, 70);
            opponentButtonComputer.TabIndex = 14;
            opponentButtonComputer.Text = "Computer";
            opponentButtonComputer.UseVisualStyleBackColor = true;
            opponentButtonComputer.Click += opponentButtonComputer_Click;
            // 
            // opponentInstructionsLabel
            // 
            opponentInstructionsLabel.AutoSize = true;
            opponentInstructionsLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opponentInstructionsLabel.ForeColor = Color.FromArgb(255, 128, 0);
            opponentInstructionsLabel.Location = new Point(75, 404);
            opponentInstructionsLabel.Name = "opponentInstructionsLabel";
            opponentInstructionsLabel.Size = new Size(345, 84);
            opponentInstructionsLabel.TabIndex = 13;
            opponentInstructionsLabel.Text = "Choose a two-player game\r\nor play the computer.";
            opponentInstructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // opponentPicture
            // 
            opponentPicture.BorderStyle = BorderStyle.Fixed3D;
            opponentPicture.Image = (Image)resources.GetObject("opponentPicture.Image");
            opponentPicture.Location = new Point(100, 100);
            opponentPicture.Name = "opponentPicture";
            opponentPicture.Size = new Size(300, 300);
            opponentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            opponentPicture.TabIndex = 9;
            opponentPicture.TabStop = false;
            // 
            // opponentButtonPlayer
            // 
            opponentButtonPlayer.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opponentButtonPlayer.Location = new Point(75, 500);
            opponentButtonPlayer.Name = "opponentButtonPlayer";
            opponentButtonPlayer.Size = new Size(160, 70);
            opponentButtonPlayer.TabIndex = 11;
            opponentButtonPlayer.Text = "Player";
            opponentButtonPlayer.UseVisualStyleBackColor = true;
            opponentButtonPlayer.Click += opponentButtonPlayer_Click;
            // 
            // opponentTitle
            // 
            opponentTitle.AutoSize = true;
            opponentTitle.BackColor = Color.Blue;
            opponentTitle.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opponentTitle.ForeColor = Color.FromArgb(255, 128, 0);
            opponentTitle.Location = new Point(35, 40);
            opponentTitle.Name = "opponentTitle";
            opponentTitle.Size = new Size(428, 46);
            opponentTitle.TabIndex = 12;
            opponentTitle.Text = "Noughts and Crosses";
            // 
            // difficultyPanel
            // 
            difficultyPanel.BackColor = Color.Blue;
            difficultyPanel.Controls.Add(difficultyButtonHard);
            difficultyPanel.Controls.Add(difficultyButtonMedium);
            difficultyPanel.Controls.Add(difficultyTitle);
            difficultyPanel.Controls.Add(difficultyInstructionsLabel);
            difficultyPanel.Controls.Add(difficultyPicture);
            difficultyPanel.Controls.Add(difficultyButtonEasy);
            difficultyPanel.Location = new Point(0, 0);
            difficultyPanel.Name = "difficultyPanel";
            difficultyPanel.Size = new Size(500, 640);
            difficultyPanel.TabIndex = 10;
            // 
            // difficultyButtonHard
            // 
            difficultyButtonHard.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difficultyButtonHard.Location = new Point(325, 500);
            difficultyButtonHard.Name = "difficultyButtonHard";
            difficultyButtonHard.Size = new Size(130, 70);
            difficultyButtonHard.TabIndex = 17;
            difficultyButtonHard.Text = "Hard";
            difficultyButtonHard.UseVisualStyleBackColor = true;
            difficultyButtonHard.Click += difficultyButtonHard_Click;
            // 
            // difficultyButtonMedium
            // 
            difficultyButtonMedium.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difficultyButtonMedium.Location = new Point(185, 500);
            difficultyButtonMedium.Name = "difficultyButtonMedium";
            difficultyButtonMedium.Size = new Size(130, 70);
            difficultyButtonMedium.TabIndex = 16;
            difficultyButtonMedium.Text = "Medium";
            difficultyButtonMedium.UseVisualStyleBackColor = true;
            difficultyButtonMedium.Click += difficultyButtonMedium_Click;
            // 
            // difficultyTitle
            // 
            difficultyTitle.AutoSize = true;
            difficultyTitle.BackColor = Color.Blue;
            difficultyTitle.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difficultyTitle.ForeColor = Color.FromArgb(255, 128, 0);
            difficultyTitle.Location = new Point(35, 40);
            difficultyTitle.Name = "difficultyTitle";
            difficultyTitle.Size = new Size(428, 46);
            difficultyTitle.TabIndex = 9;
            difficultyTitle.Text = "Noughts and Crosses";
            // 
            // difficultyInstructionsLabel
            // 
            difficultyInstructionsLabel.AutoSize = true;
            difficultyInstructionsLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difficultyInstructionsLabel.ForeColor = Color.FromArgb(255, 128, 0);
            difficultyInstructionsLabel.Location = new Point(90, 425);
            difficultyInstructionsLabel.Name = "difficultyInstructionsLabel";
            difficultyInstructionsLabel.Size = new Size(332, 42);
            difficultyInstructionsLabel.TabIndex = 15;
            difficultyInstructionsLabel.Text = "Choose the difficulty level.";
            difficultyInstructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // difficultyPicture
            // 
            difficultyPicture.BorderStyle = BorderStyle.Fixed3D;
            difficultyPicture.Image = (Image)resources.GetObject("difficultyPicture.Image");
            difficultyPicture.Location = new Point(100, 100);
            difficultyPicture.Name = "difficultyPicture";
            difficultyPicture.Size = new Size(300, 300);
            difficultyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            difficultyPicture.TabIndex = 11;
            difficultyPicture.TabStop = false;
            // 
            // difficultyButtonEasy
            // 
            difficultyButtonEasy.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difficultyButtonEasy.Location = new Point(45, 500);
            difficultyButtonEasy.Name = "difficultyButtonEasy";
            difficultyButtonEasy.Size = new Size(130, 70);
            difficultyButtonEasy.TabIndex = 1;
            difficultyButtonEasy.Text = "Easy";
            difficultyButtonEasy.UseVisualStyleBackColor = true;
            difficultyButtonEasy.Click += difficultyButtonEasy_Click;
            // 
            // loadingPanel
            // 
            loadingPanel.Controls.Add(loadingTitle);
            loadingPanel.Location = new Point(0, 0);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(500, 640);
            loadingPanel.TabIndex = 26;
            // 
            // loadingTitle
            // 
            loadingTitle.AutoSize = true;
            loadingTitle.BackColor = Color.Blue;
            loadingTitle.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadingTitle.ForeColor = Color.FromArgb(255, 128, 0);
            loadingTitle.Location = new Point(35, 272);
            loadingTitle.Name = "loadingTitle";
            loadingTitle.Size = new Size(428, 46);
            loadingTitle.TabIndex = 14;
            loadingTitle.Text = "Noughts and Crosses";
            // 
            // loadingTimer
            // 
            loadingTimer.Interval = 1000;
            loadingTimer.Tick += loadingTimer_Tick;
            // 
            // resetTimer
            // 
            resetTimer.Interval = 1000;
            resetTimer.Tick += resetTimer_Tick;
            // 
            // computerTimer
            // 
            computerTimer.Interval = 1000;
            computerTimer.Tick += computerTimer_Tick;
            // 
            // computerStartsTimer
            // 
            computerStartsTimer.Interval = 1000;
            computerStartsTimer.Tick += computerStartsTimer_Tick;
            // 
            // TitlePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(501, 641);
            Controls.Add(playingPanel);
            Controls.Add(loadingPanel);
            Controls.Add(titlePanel);
            Controls.Add(opponentPanel);
            Controls.Add(difficultyPanel);
            Controls.Add(choosePanel);
            Name = "TitlePage";
            Text = "Noughts and Crosses";
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titlePicture).EndInit();
            choosePanel.ResumeLayout(false);
            choosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)choosePicture).EndInit();
            playingPanel.ResumeLayout(false);
            playingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)counter22).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter21).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter20).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter12).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter11).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter10).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter02).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter01).EndInit();
            ((System.ComponentModel.ISupportInitialize)counter00).EndInit();
            ((System.ComponentModel.ISupportInitialize)playingBoardPicture).EndInit();
            opponentPanel.ResumeLayout(false);
            opponentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)opponentPicture).EndInit();
            difficultyPanel.ResumeLayout(false);
            difficultyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)difficultyPicture).EndInit();
            loadingPanel.ResumeLayout(false);
            loadingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button startButton;
        private Label titleTitle;
        private Panel titlePanel;
        private PictureBox titlePicture;
        private Panel choosePanel;
        private Panel playingPanel;
        private Button chooseButtonX;
        private Panel opponentPanel;
        private Button opponentButtonPlayer;
        private Panel difficultyPanel;
        private Button difficultyButtonEasy;
        private Label chooseTitle;
        private Label opponentTitle;
        private Label difficultyTitle;
        private Label playingTitle;
        private Label opponentInstructionsLabel;
        private Button opponentButtonComputer;
        private Label difficultyInstructionsLabel;
        private PictureBox opponentPicture;
        private PictureBox choosePicture;
        private PictureBox difficultyPicture;
        private Button difficultyButtonHard;
        private Button difficultyButtonMedium;
        private Label chooseInstructionsLabel;
        private Button chooseButtonRandom;
        private Button chooseButtonO;
        private Label playingInstructionsLabel;
        private PictureBox playingBoardPicture;
        private TextBox playingScreen;
        private Button playingSquare12;
        private Button playingSquare21;
        private Button playingSquare20;
        private Button playingSquare10;
        private Button playingSquare11;
        private Button playingSquare02;
        private Button playingSquare01;
        private Button playingSquare00;
        private Button playingSquare22;
        private Panel loadingPanel;
        private Label loadingTitle;
        private System.Windows.Forms.Timer loadingTimer;
        private PictureBox counter00;
        private PictureBox counter22;
        private PictureBox counter21;
        private PictureBox counter20;
        private PictureBox counter12;
        private PictureBox counter11;
        private PictureBox counter10;
        private PictureBox counter02;
        private PictureBox counter01;
        private Button resetButton;
        private System.Windows.Forms.Timer resetTimer;
        private System.Windows.Forms.Timer computerTimer;
        private System.Windows.Forms.Timer computerStartsTimer;
    }
}
