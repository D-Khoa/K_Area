namespace MyAutoClick
{
    partial class frmMain
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
            this.cmbProcess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numClickFreq = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnShowProcess = new System.Windows.Forms.Button();
            this.lbActiveProcess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbMouseY = new System.Windows.Forms.Label();
            this.lbMouseX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRun = new System.Windows.Forms.Button();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouse_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouse_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.click_freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInterval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numClickFreq)).BeginInit();
            this.pnlSetting.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProcess
            // 
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.Location = new System.Drawing.Point(112, 9);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(121, 21);
            this.cmbProcess.TabIndex = 0;
            this.cmbProcess.SelectedIndexChanged += new System.EventHandler(this.cmbProcess_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Process";
            // 
            // numClickFreq
            // 
            this.numClickFreq.Location = new System.Drawing.Point(112, 48);
            this.numClickFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClickFreq.Name = "numClickFreq";
            this.numClickFreq.Size = new System.Drawing.Size(120, 20);
            this.numClickFreq.TabIndex = 3;
            this.numClickFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose frequency";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(249, 65);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(200, 50);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.btnInterval);
            this.pnlSetting.Controls.Add(this.label5);
            this.pnlSetting.Controls.Add(this.txtInterval);
            this.pnlSetting.Controls.Add(this.btnShowProcess);
            this.pnlSetting.Controls.Add(this.lbActiveProcess);
            this.pnlSetting.Controls.Add(this.label4);
            this.pnlSetting.Controls.Add(this.btnClear);
            this.pnlSetting.Controls.Add(this.lbMouseY);
            this.pnlSetting.Controls.Add(this.lbMouseX);
            this.pnlSetting.Controls.Add(this.label3);
            this.pnlSetting.Controls.Add(this.statusStrip1);
            this.pnlSetting.Controls.Add(this.btnRun);
            this.pnlSetting.Controls.Add(this.btnAddTask);
            this.pnlSetting.Controls.Add(this.cmbProcess);
            this.pnlSetting.Controls.Add(this.label2);
            this.pnlSetting.Controls.Add(this.numClickFreq);
            this.pnlSetting.Controls.Add(this.label1);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(688, 175);
            this.pnlSetting.TabIndex = 6;
            // 
            // btnShowProcess
            // 
            this.btnShowProcess.Location = new System.Drawing.Point(249, 9);
            this.btnShowProcess.Name = "btnShowProcess";
            this.btnShowProcess.Size = new System.Drawing.Size(200, 50);
            this.btnShowProcess.TabIndex = 16;
            this.btnShowProcess.Text = "Show";
            this.btnShowProcess.UseVisualStyleBackColor = true;
            this.btnShowProcess.Click += new System.EventHandler(this.btnShowProcess_Click);
            // 
            // lbActiveProcess
            // 
            this.lbActiveProcess.AutoSize = true;
            this.lbActiveProcess.Location = new System.Drawing.Point(95, 124);
            this.lbActiveProcess.Name = "lbActiveProcess";
            this.lbActiveProcess.Size = new System.Drawing.Size(33, 13);
            this.lbActiveProcess.TabIndex = 15;
            this.lbActiveProcess.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Active process";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(455, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 50);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbMouseY
            // 
            this.lbMouseY.AutoSize = true;
            this.lbMouseY.Location = new System.Drawing.Point(181, 84);
            this.lbMouseY.Name = "lbMouseY";
            this.lbMouseY.Size = new System.Drawing.Size(13, 13);
            this.lbMouseY.TabIndex = 10;
            this.lbMouseY.Text = "0";
            // 
            // lbMouseX
            // 
            this.lbMouseX.AutoSize = true;
            this.lbMouseX.Location = new System.Drawing.Point(109, 84);
            this.lbMouseX.Name = "lbMouseX";
            this.lbMouseX.Size = new System.Drawing.Size(13, 13);
            this.lbMouseX.TabIndex = 9;
            this.lbMouseX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mouse position";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 153);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "Timer:";
            // 
            // txtTimer
            // 
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(36, 17);
            this.txtTimer.Text = "None";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(455, 65);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(200, 50);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process_name,
            this.mouse_x,
            this.mouse_y,
            this.click_freq});
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcess.Location = new System.Drawing.Point(0, 175);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.Size = new System.Drawing.Size(688, 275);
            this.dgvProcess.TabIndex = 7;
            // 
            // process_name
            // 
            this.process_name.HeaderText = "Process Name";
            this.process_name.Name = "process_name";
            // 
            // mouse_x
            // 
            this.mouse_x.HeaderText = "Mouse X";
            this.mouse_x.Name = "mouse_x";
            // 
            // mouse_y
            // 
            this.mouse_y.HeaderText = "Mouse Y";
            this.mouse_y.Name = "mouse_y";
            // 
            // click_freq
            // 
            this.click_freq.HeaderText = "Click Freq";
            this.click_freq.Name = "click_freq";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(329, 124);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(120, 20);
            this.txtInterval.TabIndex = 17;
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Timer Set";
            // 
            // btnInterval
            // 
            this.btnInterval.Location = new System.Drawing.Point(455, 122);
            this.btnInterval.Name = "btnInterval";
            this.btnInterval.Size = new System.Drawing.Size(72, 23);
            this.btnInterval.TabIndex = 19;
            this.btnInterval.Text = "Set";
            this.btnInterval.UseVisualStyleBackColor = true;
            this.btnInterval.Click += new System.EventHandler(this.btnInterval_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.dgvProcess);
            this.Controls.Add(this.pnlSetting);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoclick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numClickFreq)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numClickFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mouse_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn mouse_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn click_freq;
        private System.Windows.Forms.Label lbMouseY;
        private System.Windows.Forms.Label lbMouseX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbActiveProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Button btnInterval;
    }
}

