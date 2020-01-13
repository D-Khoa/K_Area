namespace BaseLibrary
{
    partial class BaseMediaPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.lbMediaName = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timerPlaying = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new BaseLibrary.BaseButton();
            this.btnSound = new BaseLibrary.BaseButton();
            this.btnPlay = new BaseLibrary.BaseButton();
            this.btnStop = new BaseLibrary.BaseButton();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.numVolume);
            this.pnlButtons.Controls.Add(this.trbVolume);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnSound);
            this.pnlButtons.Controls.Add(this.btnPlay);
            this.pnlButtons.Controls.Add(this.btnStop);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 40);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(265, 40);
            this.pnlButtons.TabIndex = 4;
            // 
            // numVolume
            // 
            this.numVolume.Location = new System.Drawing.Point(215, 10);
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(40, 20);
            this.numVolume.TabIndex = 5;
            this.numVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numVolume.ValueChanged += new System.EventHandler(this.numVolume_ValueChanged);
            // 
            // trbVolume
            // 
            this.trbVolume.AutoSize = false;
            this.trbVolume.Location = new System.Drawing.Point(110, 10);
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(100, 20);
            this.trbVolume.TabIndex = 4;
            this.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // lbMediaName
            // 
            this.lbMediaName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMediaName.Location = new System.Drawing.Point(0, 0);
            this.lbMediaName.Name = "lbMediaName";
            this.lbMediaName.Size = new System.Drawing.Size(180, 40);
            this.lbMediaName.TabIndex = 5;
            this.lbMediaName.Text = "Name";
            this.lbMediaName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTime.Location = new System.Drawing.Point(185, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(80, 40);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerPlaying
            // 
            this.timerPlaying.Interval = 1000;
            this.timerPlaying.Tick += new System.EventHandler(this.timerPlaying_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(35, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 20);
            this.btnNext.SrcImage = null;
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSound
            // 
            this.btnSound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSound.Location = new System.Drawing.Point(85, 10);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(20, 20);
            this.btnSound.SrcImage = null;
            this.btnSound.TabIndex = 3;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Location = new System.Drawing.Point(10, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(20, 20);
            this.btnPlay.SrcImage = null;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(60, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(20, 20);
            this.btnStop.SrcImage = null;
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BaseMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbMediaName);
            this.Controls.Add(this.pnlButtons);
            this.Name = "BaseMediaPlayer";
            this.Size = new System.Drawing.Size(265, 80);
            this.Load += new System.EventHandler(this.BaseMediaPlayer_Load);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseButton btnPlay;
        private BaseButton btnNext;
        private BaseButton btnStop;
        private BaseButton btnSound;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.Label lbMediaName;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerPlaying;
    }
}
