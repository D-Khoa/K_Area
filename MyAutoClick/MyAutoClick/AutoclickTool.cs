using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MyAutoClick
{
    public partial class AutoclickTool : Form
    {
        private readonly List<Process> AllProcess;
        private const int INTERVAL = 1000;
        private string currentProcess;
        private int bAlpha = 0;
        private Timer timer;
        public AutoclickTool()
        {
            InitializeComponent();
            AllProcess = Process.GetProcesses().ToList();
            HotKeyManager.RegisterHotKey(Keys.Q, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.W, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.E, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += HotKeyManager_HotKeyPressed;
            timer = new Timer
            {
                Interval = INTERVAL,
                Enabled = true
            };
            timer.Tick += Timer_Tick;
        }

        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.Q)
            {
                bAlpha++;
            }
            if (e.Key == Keys.W)
            {
                bAlpha--;
            }
            var AllProcess = Process.GetProcessesByName(currentProcess);
            foreach (var process in AllProcess)
            {
                if (process.ProcessName == currentProcess)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    WindowDisplayManager.SetLayeredWindowAttributes(hWnd, 0, (byte)bAlpha, WindowStyles.LWA_ALPHA);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbAlpha.Text = bAlpha.ToString();
        }

        private void AutoclickTool_Load(object sender, EventArgs e)
        {
            cmbProcess.DataSource = AllProcess.Select(x => x.ProcessName).ToArray();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var process in AllProcess)
            {
                if (process.ProcessName == currentProcess)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    WindowDisplayManager.SetWindowLong(hWnd, WindowStyles.GWL_EXSTYLE, WindowDisplayManager.GetWindowLong(Handle, WindowStyles.GWL_EXSTYLE) ^ WindowStyles.WS_OVERLAPPED);
                }
            }
        }

        private void cmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentProcess = cmbProcess.Text;
                var AllProcess = Process.GetProcessesByName(currentProcess);
                foreach (var process in AllProcess)
                {
                    if (process.ProcessName == currentProcess)
                    {
                        IntPtr hWnd = process.MainWindowHandle;
                        WindowDisplayManager.ShowWindowAsync(hWnd, WindowStyles.SW_SHOWMAXIMIZED);
                        WindowDisplayManager.SetForegroundWindow(hWnd);
                        WindowDisplayManager.SetWindowLong(hWnd, WindowStyles.GWL_EXSTYLE, WindowDisplayManager.GetWindowLong(Handle, WindowStyles.GWL_EXSTYLE) ^ WindowStyles.WS_EX_LAYERED);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
        }
    }
}
