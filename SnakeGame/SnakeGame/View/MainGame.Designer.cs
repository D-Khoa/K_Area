namespace SnakeGame
{
    partial class MainGame
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
            this.bwFPS = new System.ComponentModel.BackgroundWorker();
            this.pnlMain = new SnakeGame.BasePanelGame();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsFPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHighScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tab_Menu = new System.Windows.Forms.TabPage();
            this.tab_GamePlay = new System.Windows.Forms.TabPage();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tc_Main.SuspendLayout();
            this.tab_Menu.SuspendLayout();
            this.tab_GamePlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // bwFPS
            // 
            this.bwFPS.WorkerReportsProgress = true;
            this.bwFPS.WorkerSupportsCancellation = true;
            this.bwFPS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwFPS_DoWork);
            this.bwFPS.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwFPS_ProgressChanged);
            this.bwFPS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwFPS_RunWorkerCompleted);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(610, 382);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tsFPS,
            this.toolStripStatusLabel2,
            this.tsHighScore,
            this.tsStatus,
            this.toolStripStatusLabel1,
            this.tsScore});
            this.statusStrip1.Location = new System.Drawing.Point(3, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel3.Text = "Level :";
            // 
            // tsFPS
            // 
            this.tsFPS.Name = "tsFPS";
            this.tsFPS.Size = new System.Drawing.Size(13, 19);
            this.tsFPS.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 19);
            this.toolStripStatusLabel2.Text = "HighScore :";
            // 
            // tsHighScore
            // 
            this.tsHighScore.Name = "tsHighScore";
            this.tsHighScore.Size = new System.Drawing.Size(13, 19);
            this.tsHighScore.Text = "0";
            // 
            // tsStatus
            // 
            this.tsStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(394, 19);
            this.tsStatus.Spring = true;
            this.tsStatus.Text = "None";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 19);
            this.toolStripStatusLabel1.Text = "Score :";
            // 
            // tsScore
            // 
            this.tsScore.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsScore.Name = "tsScore";
            this.tsScore.Size = new System.Drawing.Size(17, 19);
            this.tsScore.Text = "0";
            // 
            // tc_Main
            // 
            this.tc_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_Main.Controls.Add(this.tab_Menu);
            this.tc_Main.Controls.Add(this.tab_GamePlay);
            this.tc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Main.Location = new System.Drawing.Point(0, 0);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(624, 441);
            this.tc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Main.TabIndex = 1;
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.btnHighScore);
            this.tab_Menu.Controls.Add(this.btnSetting);
            this.tab_Menu.Controls.Add(this.btnExit);
            this.tab_Menu.Controls.Add(this.btnNewGame);
            this.tab_Menu.Location = new System.Drawing.Point(4, 25);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Menu.Size = new System.Drawing.Size(616, 412);
            this.tab_Menu.TabIndex = 0;
            this.tab_Menu.Text = "Menu";
            this.tab_Menu.UseVisualStyleBackColor = true;
            // 
            // tab_GamePlay
            // 
            this.tab_GamePlay.Controls.Add(this.pnlMain);
            this.tab_GamePlay.Controls.Add(this.statusStrip1);
            this.tab_GamePlay.Location = new System.Drawing.Point(4, 25);
            this.tab_GamePlay.Name = "tab_GamePlay";
            this.tab_GamePlay.Padding = new System.Windows.Forms.Padding(3);
            this.tab_GamePlay.Size = new System.Drawing.Size(616, 412);
            this.tab_GamePlay.TabIndex = 1;
            this.tab_GamePlay.Text = "Game Play";
            this.tab_GamePlay.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(265, 143);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(265, 201);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.Location = new System.Drawing.Point(265, 172);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(75, 23);
            this.btnHighScore.TabIndex = 3;
            this.btnHighScore.Text = "Highscore";
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tc_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainGame";
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGame_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tc_Main.ResumeLayout(false);
            this.tab_Menu.ResumeLayout(false);
            this.tab_GamePlay.ResumeLayout(false);
            this.tab_GamePlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bwFPS;
        private BasePanelGame pnlMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsScore;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsFPS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsHighScore;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tab_Menu;
        private System.Windows.Forms.TabPage tab_GamePlay;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewGame;
    }
}

