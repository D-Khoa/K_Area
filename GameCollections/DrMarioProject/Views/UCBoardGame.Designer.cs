﻿namespace DrMarioProject.Views
{
    partial class UCBoardGame
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
            this.timerGameRun = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerGameRun
            // 
            this.timerGameRun.Interval = 1000;
            this.timerGameRun.Tick += new System.EventHandler(this.timerGameRun_Tick);
            // 
            // UCBoardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "UCBoardGame";
            this.SizeChanged += new System.EventHandler(this.UCBoardGame_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCBoardGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCBoardGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UCBoardGame_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGameRun;
    }
}
