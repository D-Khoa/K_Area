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
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tab_Menu = new System.Windows.Forms.TabPage();
            this.btnExit = new BaseLibrary.BaseButton();
            this.btnStart = new BaseLibrary.BaseButton();
            this.btnSetting = new BaseLibrary.BaseButton();
            this.tab_Setting = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numSoundVol = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.trbSoundVol = new System.Windows.Forms.TrackBar();
            this.rbtnSoundOff = new System.Windows.Forms.RadioButton();
            this.rbtnSoundOn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGraphic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBrowserMusic = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusicFolder = new System.Windows.Forms.TextBox();
            this.wmpMusicCollection = new BaseLibrary.BaseMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetApply = new BaseLibrary.BaseButton();
            this.btnSetBack = new BaseLibrary.BaseButton();
            this.tab_Games = new System.Windows.Forms.TabPage();
            this.tc_Main.SuspendLayout();
            this.tab_Menu.SuspendLayout();
            this.tab_Setting.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoundVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVol)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "GAME COLLECTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tc_Main
            // 
            this.tc_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_Main.Controls.Add(this.tab_Menu);
            this.tc_Main.Controls.Add(this.tab_Setting);
            this.tc_Main.Controls.Add(this.tab_Games);
            this.tc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Main.Location = new System.Drawing.Point(0, 0);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(640, 480);
            this.tc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Main.TabIndex = 7;
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.label1);
            this.tab_Menu.Controls.Add(this.btnExit);
            this.tab_Menu.Controls.Add(this.btnStart);
            this.tab_Menu.Controls.Add(this.btnSetting);
            this.tab_Menu.Location = new System.Drawing.Point(4, 25);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Menu.Size = new System.Drawing.Size(632, 451);
            this.tab_Menu.TabIndex = 0;
            this.tab_Menu.Text = "Menu";
            this.tab_Menu.UseVisualStyleBackColor = true;
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
            this.btnExit.IsCenter = true;
            this.btnExit.Location = new System.Drawing.Point(266, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.SrcImage = global::GameCollections.Properties.Resources.MenuExit;
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnStart.IsCenter = true;
            this.btnStart.Location = new System.Drawing.Point(241, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.SrcImage = global::GameCollections.Properties.Resources.MenuStart;
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.btnSetting.IsCenter = true;
            this.btnSetting.Location = new System.Drawing.Point(226, 112);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(180, 50);
            this.btnSetting.SrcImage = global::GameCollections.Properties.Resources.MenuSetting;
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // tab_Setting
            // 
            this.tab_Setting.Controls.Add(this.panel2);
            this.tab_Setting.Controls.Add(this.label3);
            this.tab_Setting.Controls.Add(this.panel3);
            this.tab_Setting.Controls.Add(this.wmpMusicCollection);
            this.tab_Setting.Controls.Add(this.label2);
            this.tab_Setting.Controls.Add(this.panel1);
            this.tab_Setting.Location = new System.Drawing.Point(4, 25);
            this.tab_Setting.Name = "tab_Setting";
            this.tab_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Setting.Size = new System.Drawing.Size(632, 451);
            this.tab_Setting.TabIndex = 1;
            this.tab_Setting.Text = "Setting";
            this.tab_Setting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numSoundVol);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.trbSoundVol);
            this.panel2.Controls.Add(this.rbtnSoundOff);
            this.panel2.Controls.Add(this.rbtnSoundOn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbGraphic);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 185);
            this.panel2.TabIndex = 10;
            // 
            // numSoundVol
            // 
            this.numSoundVol.Location = new System.Drawing.Point(230, 80);
            this.numSoundVol.Name = "numSoundVol";
            this.numSoundVol.Size = new System.Drawing.Size(50, 20);
            this.numSoundVol.TabIndex = 7;
            this.numSoundVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoundVol.ValueChanged += new System.EventHandler(this.numSoundVol_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sound Vol";
            // 
            // trbSoundVol
            // 
            this.trbSoundVol.Location = new System.Drawing.Point(100, 80);
            this.trbSoundVol.Maximum = 100;
            this.trbSoundVol.Name = "trbSoundVol";
            this.trbSoundVol.Size = new System.Drawing.Size(121, 45);
            this.trbSoundVol.TabIndex = 5;
            this.trbSoundVol.Scroll += new System.EventHandler(this.trbSoundVol_Scroll);
            // 
            // rbtnSoundOff
            // 
            this.rbtnSoundOff.AutoSize = true;
            this.rbtnSoundOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSoundOff.Location = new System.Drawing.Point(235, 48);
            this.rbtnSoundOff.Name = "rbtnSoundOff";
            this.rbtnSoundOff.Size = new System.Drawing.Size(45, 21);
            this.rbtnSoundOff.TabIndex = 4;
            this.rbtnSoundOff.TabStop = true;
            this.rbtnSoundOff.Text = "Off";
            this.rbtnSoundOff.UseVisualStyleBackColor = true;
            // 
            // rbtnSoundOn
            // 
            this.rbtnSoundOn.AutoSize = true;
            this.rbtnSoundOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSoundOn.Location = new System.Drawing.Point(100, 48);
            this.rbtnSoundOn.Name = "rbtnSoundOn";
            this.rbtnSoundOn.Size = new System.Drawing.Size(45, 21);
            this.rbtnSoundOn.TabIndex = 3;
            this.rbtnSoundOn.TabStop = true;
            this.rbtnSoundOn.Text = "On";
            this.rbtnSoundOn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sound";
            // 
            // cmbGraphic
            // 
            this.cmbGraphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphic.FormattingEnabled = true;
            this.cmbGraphic.Items.AddRange(new object[] {
            "640x480",
            "800x600",
            "1366x768",
            "1600x900",
            "1920x1080",
            "1920x1200",
            "2560x1440",
            "2560x1600"});
            this.cmbGraphic.Location = new System.Drawing.Point(100, 20);
            this.cmbGraphic.Name = "cmbGraphic";
            this.cmbGraphic.Size = new System.Drawing.Size(180, 21);
            this.cmbGraphic.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Graphic";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(3, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "MUSIC COLLECTION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBrowserMusic);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMusicFolder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 30);
            this.panel3.TabIndex = 11;
            // 
            // btnBrowserMusic
            // 
            this.btnBrowserMusic.Location = new System.Drawing.Point(520, 5);
            this.btnBrowserMusic.Name = "btnBrowserMusic";
            this.btnBrowserMusic.Size = new System.Drawing.Size(80, 20);
            this.btnBrowserMusic.TabIndex = 2;
            this.btnBrowserMusic.Text = "Browser";
            this.btnBrowserMusic.UseVisualStyleBackColor = true;
            this.btnBrowserMusic.Click += new System.EventHandler(this.btnBrowserMusic_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Link";
            // 
            // txtMusicFolder
            // 
            this.txtMusicFolder.Location = new System.Drawing.Point(50, 5);
            this.txtMusicFolder.Name = "txtMusicFolder";
            this.txtMusicFolder.ReadOnly = true;
            this.txtMusicFolder.Size = new System.Drawing.Size(460, 20);
            this.txtMusicFolder.TabIndex = 0;
            this.txtMusicFolder.TextChanged += new System.EventHandler(this.txtMusicFolder_TextChanged);
            // 
            // wmpMusicCollection
            // 
            this.wmpMusicCollection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wmpMusicCollection.Isplaying = false;
            this.wmpMusicCollection.LoadPlaylist = false;
            this.wmpMusicCollection.Location = new System.Drawing.Point(3, 318);
            this.wmpMusicCollection.Name = "wmpMusicCollection";
            this.wmpMusicCollection.Size = new System.Drawing.Size(626, 80);
            this.wmpMusicCollection.SrcImage = global::GameCollections.Properties.Resources.MediaPlayerButton;
            this.wmpMusicCollection.SrcMusicURL = null;
            this.wmpMusicCollection.TabIndex = 7;
            this.wmpMusicCollection.Volume = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "SETTING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSetApply);
            this.panel1.Controls.Add(this.btnSetBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 50);
            this.panel1.TabIndex = 8;
            // 
            // btnSetApply
            // 
            this.btnSetApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetApply.BackgroundImage")));
            this.btnSetApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetApply.FlatAppearance.BorderSize = 0;
            this.btnSetApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetApply.IsCenter = false;
            this.btnSetApply.Location = new System.Drawing.Point(0, 0);
            this.btnSetApply.Name = "btnSetApply";
            this.btnSetApply.Size = new System.Drawing.Size(120, 50);
            this.btnSetApply.SrcImage = global::GameCollections.Properties.Resources.MenuApply;
            this.btnSetApply.TabIndex = 1;
            this.btnSetApply.UseVisualStyleBackColor = true;
            this.btnSetApply.Click += new System.EventHandler(this.btnSetApply_Click);
            // 
            // btnSetBack
            // 
            this.btnSetBack.BackColor = System.Drawing.Color.Transparent;
            this.btnSetBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetBack.BackgroundImage")));
            this.btnSetBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetBack.FlatAppearance.BorderSize = 0;
            this.btnSetBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetBack.IsCenter = false;
            this.btnSetBack.Location = new System.Drawing.Point(526, 0);
            this.btnSetBack.Name = "btnSetBack";
            this.btnSetBack.Size = new System.Drawing.Size(100, 50);
            this.btnSetBack.SrcImage = global::GameCollections.Properties.Resources.MenuExit;
            this.btnSetBack.TabIndex = 0;
            this.btnSetBack.UseVisualStyleBackColor = false;
            this.btnSetBack.Click += new System.EventHandler(this.btnSetBack_Click);
            // 
            // tab_Games
            // 
            this.tab_Games.Location = new System.Drawing.Point(4, 25);
            this.tab_Games.Name = "tab_Games";
            this.tab_Games.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Games.Size = new System.Drawing.Size(632, 451);
            this.tab_Games.TabIndex = 2;
            this.tab_Games.Text = "Games";
            this.tab_Games.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.tc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tc_Main.ResumeLayout(false);
            this.tab_Menu.ResumeLayout(false);
            this.tab_Setting.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoundVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVol)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BaseLibrary.BaseButton btnStart;
        private BaseLibrary.BaseButton btnSetting;
        private BaseLibrary.BaseButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tab_Menu;
        private System.Windows.Forms.TabPage tab_Setting;
        private BaseLibrary.BaseButton btnSetBack;
        private BaseLibrary.BaseButton btnSetApply;
        private System.Windows.Forms.Label label2;
        private BaseLibrary.BaseMediaPlayer wmpMusicCollection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBrowserMusic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusicFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbGraphic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnSoundOff;
        private System.Windows.Forms.RadioButton rbtnSoundOn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trbSoundVol;
        private System.Windows.Forms.NumericUpDown numSoundVol;
        private System.Windows.Forms.TabPage tab_Games;
    }
}

