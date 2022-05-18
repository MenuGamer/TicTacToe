namespace TicTacToeTeacher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.WindowIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MoveWindow = new System.Windows.Forms.Timer(this.components);
            this.ScoreboardSeprator = new System.Windows.Forms.Label();
            this.TicTacToeEndPanel1 = new TicTacToeTeacher.UI.TicTacToeEndPanel();
            this.ExitButton = new TicTacToeTeacher.UI.TicTacToeButton();
            this.PlayAgainButton = new TicTacToeTeacher.UI.TicTacToeButton();
            this.WinningText = new System.Windows.Forms.Label();
            this.ScorePanelPlayer2 = new TicTacToeTeacher.UI.TicTacToeScorePanel();
            this.ScorePanelPlayer1 = new TicTacToeTeacher.UI.TicTacToeScorePanel();
            this.Row3Tile3 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row3Tile2 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row3Tile1 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row2Tile3 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row2Tile2 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row2Tile1 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row1Tile3 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row1Tile2 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.Row1Tile1 = new TicTacToeTeacher.UI.TicTacToePanel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.TicTacToeEndPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this.ApplicationTitle);
            this.TopPanel.Controls.Add(this.WindowIcon);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(450, 20);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.ApplicationTitle.Location = new System.Drawing.Point(20, 0);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(91, 20);
            this.ApplicationTitle.TabIndex = 3;
            this.ApplicationTitle.Text = "TicTacToe";
            this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplicationTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.ApplicationTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // WindowIcon
            // 
            this.WindowIcon.BackgroundImage = global::TicTacToeTeacher.Properties.Resources.TicTacToeWhiteIcon;
            this.WindowIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowIcon.Location = new System.Drawing.Point(0, 0);
            this.WindowIcon.Name = "WindowIcon";
            this.WindowIcon.Size = new System.Drawing.Size(20, 20);
            this.WindowIcon.TabIndex = 2;
            this.WindowIcon.TabStop = false;
            this.WindowIcon.Tag = "Icon";
            this.WindowIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.WindowIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::TicTacToeTeacher.Properties.Resources.Minimize_Night;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.Location = new System.Drawing.Point(410, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Tag = "Minimize";
            this.MinimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WindowButton_MouseClick);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.WindowButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.WindowButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::TicTacToeTeacher.Properties.Resources.CloseWindow_Night;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Location = new System.Drawing.Point(430, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Tag = "Close";
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WindowButton_MouseClick);
            this.CloseButton.MouseEnter += new System.EventHandler(this.WindowButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.WindowButton_MouseLeave);
            // 
            // MoveWindow
            // 
            this.MoveWindow.Interval = 10;
            this.MoveWindow.Tick += new System.EventHandler(this.MoveWindow_Tick);
            // 
            // ScoreboardSeprator
            // 
            this.ScoreboardSeprator.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreboardSeprator.ForeColor = System.Drawing.Color.White;
            this.ScoreboardSeprator.Location = new System.Drawing.Point(201, 41);
            this.ScoreboardSeprator.Name = "ScoreboardSeprator";
            this.ScoreboardSeprator.Size = new System.Drawing.Size(52, 28);
            this.ScoreboardSeprator.TabIndex = 4;
            this.ScoreboardSeprator.Text = "-";
            this.ScoreboardSeprator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToeEndPanel1
            // 
            this.TicTacToeEndPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.TicTacToeEndPanel1.Controls.Add(this.ExitButton);
            this.TicTacToeEndPanel1.Controls.Add(this.PlayAgainButton);
            this.TicTacToeEndPanel1.Controls.Add(this.WinningText);
            this.TicTacToeEndPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TicTacToeEndPanel1.Location = new System.Drawing.Point(72, 160);
            this.TicTacToeEndPanel1.Name = "TicTacToeEndPanel1";
            this.TicTacToeEndPanel1.RoundAmmount = 12;
            this.TicTacToeEndPanel1.Size = new System.Drawing.Size(313, 172);
            this.TicTacToeEndPanel1.TabIndex = 0;
            this.TicTacToeEndPanel1.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Alignment = System.Drawing.StringAlignment.Center;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ExitButton.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.ExitButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.InnerText = "Exit";
            this.ExitButton.Line = System.Drawing.StringAlignment.Center;
            this.ExitButton.Location = new System.Drawing.Point(36, 122);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RoundAmmount = 9;
            this.ExitButton.Size = new System.Drawing.Size(87, 21);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Alignment = System.Drawing.StringAlignment.Center;
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PlayAgainButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.PlayAgainButton.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.PlayAgainButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PlayAgainButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.White;
            this.PlayAgainButton.InnerText = "Play again";
            this.PlayAgainButton.Line = System.Drawing.StringAlignment.Center;
            this.PlayAgainButton.Location = new System.Drawing.Point(187, 122);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.RoundAmmount = 9;
            this.PlayAgainButton.Size = new System.Drawing.Size(87, 21);
            this.PlayAgainButton.TabIndex = 0;
            this.PlayAgainButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayAgainButton_MouseClick);
            // 
            // WinningText
            // 
            this.WinningText.BackColor = System.Drawing.Color.Transparent;
            this.WinningText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningText.ForeColor = System.Drawing.Color.White;
            this.WinningText.Location = new System.Drawing.Point(36, 24);
            this.WinningText.Name = "WinningText";
            this.WinningText.Size = new System.Drawing.Size(238, 40);
            this.WinningText.TabIndex = 0;
            this.WinningText.Text = "Tie!";
            this.WinningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScorePanelPlayer2
            // 
            this.ScorePanelPlayer2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ScorePanelPlayer2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePanelPlayer2.ForeColor = System.Drawing.Color.White;
            this.ScorePanelPlayer2.InnerText = "O - Player 2";
            this.ScorePanelPlayer2.Inverted = true;
            this.ScorePanelPlayer2.Location = new System.Drawing.Point(259, 41);
            this.ScorePanelPlayer2.Name = "ScorePanelPlayer2";
            this.ScorePanelPlayer2.RoundAmmount = 9;
            this.ScorePanelPlayer2.Score = 0;
            this.ScorePanelPlayer2.Size = new System.Drawing.Size(160, 28);
            this.ScorePanelPlayer2.TabIndex = 3;
            // 
            // ScorePanelPlayer1
            // 
            this.ScorePanelPlayer1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ScorePanelPlayer1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePanelPlayer1.ForeColor = System.Drawing.Color.White;
            this.ScorePanelPlayer1.InnerText = "Player 1 - X";
            this.ScorePanelPlayer1.Inverted = false;
            this.ScorePanelPlayer1.Location = new System.Drawing.Point(32, 41);
            this.ScorePanelPlayer1.Name = "ScorePanelPlayer1";
            this.ScorePanelPlayer1.RoundAmmount = 9;
            this.ScorePanelPlayer1.Score = 0;
            this.ScorePanelPlayer1.Size = new System.Drawing.Size(163, 28);
            this.ScorePanelPlayer1.TabIndex = 0;
            // 
            // Row3Tile3
            // 
            this.Row3Tile3.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row3Tile3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row3Tile3.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row3Tile3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row3Tile3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row3Tile3.ForeColor = System.Drawing.Color.White;
            this.Row3Tile3.Location = new System.Drawing.Point(294, 309);
            this.Row3Tile3.Name = "Row3Tile3";
            this.Row3Tile3.RoundAmmount = 12;
            this.Row3Tile3.Size = new System.Drawing.Size(125, 100);
            this.Row3Tile3.TabIndex = 2;
            this.Row3Tile3.Tag = "tile";
            this.Row3Tile3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row3Tile2
            // 
            this.Row3Tile2.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row3Tile2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row3Tile2.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row3Tile2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row3Tile2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row3Tile2.ForeColor = System.Drawing.Color.White;
            this.Row3Tile2.Location = new System.Drawing.Point(163, 309);
            this.Row3Tile2.Name = "Row3Tile2";
            this.Row3Tile2.RoundAmmount = 12;
            this.Row3Tile2.Size = new System.Drawing.Size(125, 100);
            this.Row3Tile2.TabIndex = 2;
            this.Row3Tile2.Tag = "tile";
            this.Row3Tile2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row3Tile1
            // 
            this.Row3Tile1.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row3Tile1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row3Tile1.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row3Tile1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row3Tile1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row3Tile1.ForeColor = System.Drawing.Color.White;
            this.Row3Tile1.Location = new System.Drawing.Point(32, 309);
            this.Row3Tile1.Name = "Row3Tile1";
            this.Row3Tile1.RoundAmmount = 12;
            this.Row3Tile1.Size = new System.Drawing.Size(125, 100);
            this.Row3Tile1.TabIndex = 2;
            this.Row3Tile1.Tag = "tile";
            this.Row3Tile1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row2Tile3
            // 
            this.Row2Tile3.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row2Tile3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row2Tile3.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row2Tile3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row2Tile3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row2Tile3.ForeColor = System.Drawing.Color.White;
            this.Row2Tile3.Location = new System.Drawing.Point(294, 203);
            this.Row2Tile3.Name = "Row2Tile3";
            this.Row2Tile3.RoundAmmount = 12;
            this.Row2Tile3.Size = new System.Drawing.Size(125, 100);
            this.Row2Tile3.TabIndex = 2;
            this.Row2Tile3.Tag = "tile";
            this.Row2Tile3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row2Tile2
            // 
            this.Row2Tile2.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row2Tile2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row2Tile2.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row2Tile2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row2Tile2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row2Tile2.ForeColor = System.Drawing.Color.White;
            this.Row2Tile2.Location = new System.Drawing.Point(163, 203);
            this.Row2Tile2.Name = "Row2Tile2";
            this.Row2Tile2.RoundAmmount = 12;
            this.Row2Tile2.Size = new System.Drawing.Size(125, 100);
            this.Row2Tile2.TabIndex = 2;
            this.Row2Tile2.Tag = "tile";
            this.Row2Tile2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row2Tile1
            // 
            this.Row2Tile1.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row2Tile1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row2Tile1.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row2Tile1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row2Tile1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row2Tile1.ForeColor = System.Drawing.Color.White;
            this.Row2Tile1.Location = new System.Drawing.Point(32, 203);
            this.Row2Tile1.Name = "Row2Tile1";
            this.Row2Tile1.RoundAmmount = 12;
            this.Row2Tile1.Size = new System.Drawing.Size(125, 100);
            this.Row2Tile1.TabIndex = 2;
            this.Row2Tile1.Tag = "tile";
            this.Row2Tile1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row1Tile3
            // 
            this.Row1Tile3.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row1Tile3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row1Tile3.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row1Tile3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row1Tile3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row1Tile3.ForeColor = System.Drawing.Color.White;
            this.Row1Tile3.Location = new System.Drawing.Point(294, 97);
            this.Row1Tile3.Name = "Row1Tile3";
            this.Row1Tile3.RoundAmmount = 12;
            this.Row1Tile3.Size = new System.Drawing.Size(125, 100);
            this.Row1Tile3.TabIndex = 2;
            this.Row1Tile3.Tag = "tile";
            this.Row1Tile3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row1Tile2
            // 
            this.Row1Tile2.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row1Tile2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row1Tile2.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row1Tile2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row1Tile2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row1Tile2.ForeColor = System.Drawing.Color.White;
            this.Row1Tile2.Location = new System.Drawing.Point(163, 97);
            this.Row1Tile2.Name = "Row1Tile2";
            this.Row1Tile2.RoundAmmount = 12;
            this.Row1Tile2.Size = new System.Drawing.Size(125, 100);
            this.Row1Tile2.TabIndex = 2;
            this.Row1Tile2.Tag = "tile";
            this.Row1Tile2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Row1Tile1
            // 
            this.Row1Tile1.CurrentState = TicTacToeTeacher.UI.TicTacToePanel.TicTacToeState.None;
            this.Row1Tile1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Row1Tile1.FillDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Row1Tile1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Row1Tile1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row1Tile1.ForeColor = System.Drawing.Color.White;
            this.Row1Tile1.Location = new System.Drawing.Point(32, 97);
            this.Row1Tile1.Name = "Row1Tile1";
            this.Row1Tile1.RoundAmmount = 12;
            this.Row1Tile1.Size = new System.Drawing.Size(125, 100);
            this.Row1Tile1.TabIndex = 1;
            this.Row1Tile1.Tag = "tile";
            this.Row1Tile1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TicTacToeButton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.TicTacToeEndPanel1);
            this.Controls.Add(this.ScoreboardSeprator);
            this.Controls.Add(this.ScorePanelPlayer2);
            this.Controls.Add(this.ScorePanelPlayer1);
            this.Controls.Add(this.Row3Tile3);
            this.Controls.Add(this.Row3Tile2);
            this.Controls.Add(this.Row3Tile1);
            this.Controls.Add(this.Row2Tile3);
            this.Controls.Add(this.Row2Tile2);
            this.Controls.Add(this.Row2Tile1);
            this.Controls.Add(this.Row1Tile3);
            this.Controls.Add(this.Row1Tile2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Row1Tile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WindowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.TicTacToeEndPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private TicTacToeTeacher.UI.TicTacToePanel Row1Tile1;
        private UI.TicTacToePanel Row1Tile2;
        private UI.TicTacToePanel Row1Tile3;
        private UI.TicTacToePanel Row2Tile1;
        private UI.TicTacToePanel Row2Tile2;
        private UI.TicTacToePanel Row2Tile3;
        private UI.TicTacToePanel Row3Tile1;
        private UI.TicTacToePanel Row3Tile2;
        private UI.TicTacToePanel Row3Tile3;
        private UI.TicTacToeScorePanel ScorePanelPlayer1;
        private System.Windows.Forms.Timer MoveWindow;
        private UI.TicTacToeScorePanel ScorePanelPlayer2;
        private System.Windows.Forms.Label ScoreboardSeprator;
        private System.Windows.Forms.PictureBox WindowIcon;
        private System.Windows.Forms.Label ApplicationTitle;
        private TicTacToeTeacher.UI.TicTacToeEndPanel TicTacToeEndPanel1;
        private UI.TicTacToeButton PlayAgainButton;
        private System.Windows.Forms.Label WinningText;
        private UI.TicTacToeButton ExitButton;
    }
}

