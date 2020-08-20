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
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbProcess = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.stBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAlpha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlSetting.SuspendLayout();
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
            this.dgvData.Location = new System.Drawing.Point(0, 58);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(800, 370);
            this.dgvData.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // process
            // 
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
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.lbAlpha);
            this.pnlSetting.Controls.Add(this.label1);
            this.pnlSetting.Controls.Add(this.btnHide);
            this.pnlSetting.Controls.Add(this.btnAdd);
            this.pnlSetting.Controls.Add(this.cmbProcess);
            this.pnlSetting.Controls.Add(this.btnRun);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(800, 58);
            this.pnlSetting.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbProcess
            // 
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.Location = new System.Drawing.Point(12, 12);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(121, 21);
            this.cmbProcess.TabIndex = 1;
            this.cmbProcess.SelectedIndexChanged += new System.EventHandler(this.cmbProcess_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(713, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // stBar
            // 
            this.stBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.txtPosX,
            this.toolStripStatusLabel3,
            this.txtPosY});
            this.stBar.Location = new System.Drawing.Point(0, 428);
            this.stBar.Name = "stBar";
            this.stBar.Size = new System.Drawing.Size(800, 22);
            this.stBar.TabIndex = 2;
            this.stBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel2.Text = "X:";
            // 
            // txtPosX
            // 
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(13, 17);
            this.txtPosX.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel3.Text = "Y:";
            // 
            // txtPosY
            // 
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(13, 17);
            this.txtPosY.Text = "0";
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(632, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alpha";
            // 
            // lbAlpha
            // 
            this.lbAlpha.AutoSize = true;
            this.lbAlpha.Location = new System.Drawing.Point(52, 36);
            this.lbAlpha.Name = "lbAlpha";
            this.lbAlpha.Size = new System.Drawing.Size(33, 13);
            this.lbAlpha.TabIndex = 5;
            this.lbAlpha.Text = "None";
            // 
            // AutoclickTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.stBar);
            this.Controls.Add(this.pnlSetting);
            this.Name = "AutoclickTool";
            this.Text = "AutoclickTool";
            this.Load += new System.EventHandler(this.AutoclickTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.stBar.ResumeLayout(false);
            this.stBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn posX;
        private System.Windows.Forms.DataGridViewTextBoxColumn posY;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbProcess;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.StatusStrip stBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtPosX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtPosY;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lbAlpha;
        private System.Windows.Forms.Label label1;
    }
}