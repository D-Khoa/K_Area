namespace MyAutoClick
{
    partial class AutoclickTool
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stBar = new System.Windows.Forms.StatusStrip();
            this.lbCurrentProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbAlpha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHide = new System.Windows.Forms.ToolStripSplitButton();
            this.cmbProcess = new System.Windows.Forms.ToolStripComboBox();
            this.btnRun = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.stBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.process,
            this.posX,
            this.posY,
            this.freq,
            this.enable});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(784, 437);
            this.dgvData.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // process
            // 
            this.process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.process.HeaderText = "Process";
            this.process.Name = "process";
            // 
            // posX
            // 
            this.posX.HeaderText = "X";
            this.posX.Name = "posX";
            // 
            // posY
            // 
            this.posY.HeaderText = "Y";
            this.posY.Name = "posY";
            // 
            // freq
            // 
            this.freq.HeaderText = "Freq";
            this.freq.Name = "freq";
            // 
            // enable
            // 
            this.enable.HeaderText = "Enable";
            this.enable.Name = "enable";
            // 
            // stBar
            // 
            this.stBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCurrentProcess,
            this.toolStripStatusLabel5,
            this.lbAlpha,
            this.toolStripStatusLabel2,
            this.txtPosX,
            this.toolStripStatusLabel3,
            this.txtPosY,
            this.lbStatus,
            this.btnHide});
            this.stBar.Location = new System.Drawing.Point(0, 437);
            this.stBar.Name = "stBar";
            this.stBar.Size = new System.Drawing.Size(784, 24);
            this.stBar.TabIndex = 2;
            this.stBar.Text = "Status Bar";
            // 
            // lbCurrentProcess
            // 
            this.lbCurrentProcess.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lbCurrentProcess.Name = "lbCurrentProcess";
            this.lbCurrentProcess.Size = new System.Drawing.Size(40, 19);
            this.lbCurrentProcess.Text = "None";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabel5.Text = "Alpha:";
            // 
            // lbAlpha
            // 
            this.lbAlpha.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbAlpha.Name = "lbAlpha";
            this.lbAlpha.Size = new System.Drawing.Size(17, 19);
            this.lbAlpha.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(21, 19);
            this.toolStripStatusLabel2.Text = "X:";
            // 
            // txtPosX
            // 
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(13, 19);
            this.txtPosX.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 19);
            this.toolStripStatusLabel3.Text = "Y:";
            // 
            // txtPosY
            // 
            this.txtPosY.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(17, 19);
            this.txtPosY.Text = "0";
            // 
            // lbStatus
            // 
            this.lbStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(504, 19);
            this.lbStatus.Spring = true;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.Control;
            this.btnHide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbProcess,
            this.btnRun,
            this.btnAdd});
            this.btnHide.Image = global::MyAutoClick.Properties.Resources._3_1_Texting;
            this.btnHide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(64, 22);
            this.btnHide.Text = "Hide";
            this.btnHide.ButtonClick += new System.EventHandler(this.btnHide_Click);
            // 
            // cmbProcess
            // 
            this.cmbProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(121, 23);
            this.cmbProcess.SelectedIndexChanged += new System.EventHandler(this.cmbProcess_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(181, 22);
            this.btnRun.Text = "Run";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AutoclickTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.stBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AutoclickTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoclickTool";
            this.Load += new System.EventHandler(this.AutoclickTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.stBar.ResumeLayout(false);
            this.stBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.StatusStrip stBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtPosX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtPosY;
        private System.Windows.Forms.ToolStripSplitButton btnHide;
        private System.Windows.Forms.ToolStripMenuItem btnRun;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lbAlpha;
        private System.Windows.Forms.ToolStripComboBox cmbProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn posX;
        private System.Windows.Forms.DataGridViewTextBoxColumn posY;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enable;
        private System.Windows.Forms.ToolStripStatusLabel lbCurrentProcess;
    }
}