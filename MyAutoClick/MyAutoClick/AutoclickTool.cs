using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static MyAutoClick.HotKeyManager;
using static MyAutoClick.WindowDisplayManager;

namespace MyAutoClick
{
    public partial class AutoclickTool : Form
    {
        private readonly List<Process> AllProcess;
        private const int INTERVAL = 100;
        private readonly Timer timer;
        private IntPtr CurrentHwnd;
        private bool isShow = false;
        private byte bAlpha = 128;
        public AutoclickTool()
        {
            InitializeComponent();
            AllProcess = Process.GetProcesses().ToList();
            RegisterHotKey(Keys.Q, KeyModifiers.Alt);
            RegisterHotKey(Keys.W, KeyModifiers.Alt);
            RegisterHotKey(Keys.E, KeyModifiers.Alt);
            HotKeyPressed += HotKeyManager_HotKeyPressed;
            timer = new Timer
            {
                Interval = INTERVAL,
                Enabled = true
            };
            timer.Tick += Timer_Tick;
        }
        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            switch (e.Modifiers)
            {
                case KeyModifiers.Alt:
                    switch (e.Key)
                    {
                        case Keys.Q:
                            if (bAlpha > 0) bAlpha--;
                            break;
                        case Keys.W:
                            if (bAlpha < 255) bAlpha++;
                            break;
                        case Keys.E:
                            CurrentHwnd = GetForegroundWindow();
                            isShow = true;
                            break;
                    }
                    break;
            }
            SetLayeredWindowAttributes(CurrentHwnd, 0, bAlpha, WindowStyles.LWA_ALPHA);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                SetWindowLongTask();
                isShow = false;
            }
            lbAlpha.Text = bAlpha.ToString();
            lbStatus.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void AutoclickTool_Load(object sender, EventArgs e)
        {
            cmbProcess.Items.AddRange(AllProcess.OrderBy(x => x.ProcessName).Select(x => x.ProcessName).ToArray());
        }
        private void cmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbCurrentProcess.Text = cmbProcess.Text;
                var AllProcess = Process.GetProcessesByName(cmbProcess.Text);
                foreach (var process in AllProcess)
                {
                    if (process.ProcessName == cmbProcess.Text)
                    {
                        IntPtr hWnd = process.MainWindowHandle;
                        if (IntPtr.Zero != hWnd)
                        {
                            ShowWindowAsync(hWnd, WindowStyles.SW_RESTORE);
                            SetForegroundWindow(hWnd);
                            CurrentHwnd = hWnd;
                            isShow = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (dgvData.Visible)
            {
                btnHide.Text = "Show";
                dgvData.Visible = false;
                this.TopMost = true;
                this.ControlBox = false;
                this.Size = new System.Drawing.Size(500, 60);
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            else
            {
                btnHide.Text = "Hide";
                dgvData.Visible = true;
                this.TopMost = false;
                this.ControlBox = true;
                this.Size = new System.Drawing.Size(800, 500);
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void SetWindowLongTask()
        {
            if (IntPtr.Zero != CurrentHwnd)
            {
                SetWindowLong(CurrentHwnd, WindowStyles.GWL_EXSTYLE, GetWindowLong(Handle, WindowStyles.GWL_EXSTYLE) ^ WindowStyles.WS_EX_LAYERED);
                GetLayeredWindowAttributes(CurrentHwnd, out uint crKey, out bAlpha, out uint dwFlags);
            }
            var threadID = GetWindowThreadProcessId(CurrentHwnd, out uint processID);
            var CurrentProcess = Process.GetProcessById(Convert.ToInt32(processID));
            lbCurrentProcess.Text = CurrentProcess.ProcessName;
        }
    }
}
