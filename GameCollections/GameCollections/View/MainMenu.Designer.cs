namespace GameCollections
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new BaseLibrary.BaseButton();
            this.btnSetting = new BaseLibrary.BaseButton();
            this.btnStart = new BaseLibrary.BaseButton();
            this.wmpBackGroundMusic = new BaseLibrary.BaseMediaPlayer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Audiowide", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "GAME COLLECTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(100, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.SrcImage = global::GameCollections.Properties.Resources.MenuExit;
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetting.Location = new System.Drawing.Point(100, 100);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 50);
            this.btnSetting.SrcImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.SrcImage")));
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(100, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 50);
            this.btnStart.SrcImage = ((System.Drawing.Image)(resources.GetObject("btnStart.SrcImage")));
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // wmpBackGroundMusic
            // 
            this.wmpBackGroundMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wmpBackGroundMusic.Isplaying = true;
            this.wmpBackGroundMusic.Location = new System.Drawing.Point(0, 207);
            this.wmpBackGroundMusic.Name = "wmpBackGroundMusic";
            this.wmpBackGroundMusic.Size = new System.Drawing.Size(400, 88);
            this.wmpBackGroundMusic.SrcImage = global::GameCollections.Properties.Resources.MediaPlayerButton;
            this.wmpBackGroundMusic.SrcMusicURL = "..\\..\\Resources\\Music";
            this.wmpBackGroundMusic.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.wmpBackGroundMusic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private BaseLibrary.BaseButton btnStart;
        private BaseLibrary.BaseButton btnSetting;
        private BaseLibrary.BaseButton btnExit;
        private System.Windows.Forms.Label label1;
        private BaseLibrary.BaseMediaPlayer wmpBackGroundMusic;
    }
}

