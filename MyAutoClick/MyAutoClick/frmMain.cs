using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyAutoClick
{
    public partial class frmMain : Form
    {
        private const int INTERVAL = 500;
        private Point currentMousePos;
        private Timer timer;
        private int counter;
        private bool isRun;
        public frmMain()
        {
            InitializeComponent();
            counter = 0;
            isRun = false;
            timer = new Timer
            {
                Interval = INTERVAL,
                Enabled = true
            };
            timer.Tick += Timer_Tick;
            HotKeyManager.RegisterHotKey(Keys.F2, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.F3, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }
        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.F2 && e.Modifiers == KeyModifiers.Alt)
            {
                MouseEventManager.GetCursorPos(out currentMousePos);
                var currentProcess = Process.GetCurrentProcess();
                IntPtr hWnd = currentProcess.MainWindowHandle;
                WindowDisplayManager.ShowWindowAsync(hWnd, WindowDisplayManager.SW_RESTORE);
                WindowDisplayManager.SetForegroundWindow(hWnd);
            }
            if (e.Key == Keys.F3 && e.Modifiers == KeyModifiers.Alt)
            {
                isRun = !isRun;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                IntPtr activeHandle = WindowDisplayManager.GetForegroundWindow();
                WindowDisplayManager.GetWindowThreadProcessId(activeHandle, out uint activeProcessID);
                var activeProcess = Process.GetProcessById((int)activeProcessID);
                lbActiveProcess.Text = activeProcess.ProcessName;
                lbMouseX.Text = string.Format("X:{0}", currentMousePos.X);
                lbMouseY.Text = string.Format("Y:{0}", currentMousePos.X);
                txtTimer.Text = counter.ToString();
                if (isRun)
                {
                    btnRun.Text = "Stop";
                    for (int i = 0; i < dgvProcess.Rows.Count; i++)
                    {
                        var currentProcessName = dgvProcess.Rows[i].Cells[0].Value.ToString();
                        if (currentProcessName == activeProcess.ProcessName)
                        {
                            int X = int.Parse(dgvProcess.Rows[i].Cells[1].Value.ToString());
                            int Y = int.Parse(dgvProcess.Rows[i].Cells[2].Value.ToString());
                            int freq = int.Parse(dgvProcess.Rows[i].Cells[3].Value.ToString());
                            var AllProcess = Process.GetProcessesByName(currentProcessName);
                            foreach (var process in AllProcess)
                            {
                                IntPtr hWnd = process.MainWindowHandle;
                                MouseEventManager.ClickOnPoint(hWnd, new Point(X, Y), freq);
                            }
                            System.Threading.Thread.Sleep(50);
                        }
                    }
                }
                else btnRun.Text = "Run";
                counter++;
            }
            catch
            {

            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            var AllProcess = Process.GetProcesses();
            cmbProcess.DataSource = AllProcess.OrderBy(x => x.ProcessName).Select(x => x.ProcessName).Distinct().ToList();
            string filename = Path.Combine(Environment.CurrentDirectory, "dataclick.txt");
            if (File.Exists(filename))
            {
                using (var fr = new StreamReader(filename, false))
                {
                    while (!fr.EndOfStream)
                    {
                        var line = fr.ReadLine();
                        string[] row = line.Split(';');
                        dgvProcess.Rows.Add(row);
                    }
                    fr.Close();
                    fr.Dispose();
                }
            }
            txtInterval.Text = timer.Interval.ToString();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            isRun = !isRun;
        }
        private void cmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var processName = cmbProcess.Text;
                var AllProcess = Process.GetProcessesByName(processName);
                foreach (var process in AllProcess)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    WindowDisplayManager.ShowWindowAsync(hWnd, WindowDisplayManager.SW_SHOWMAXIMIZED);
                    WindowDisplayManager.SetForegroundWindow(hWnd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var processName = cmbProcess.Text;
            var dr = dgvProcess.Rows[dgvProcess.Rows.Add()];
            dr.Cells[0].Value = processName;
            dr.Cells[1].Value = currentMousePos.X;
            dr.Cells[2].Value = currentMousePos.Y;
            dr.Cells[3].Value = numClickFreq.Value;
            dgvProcess.Update();
            dgvProcess.Refresh();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvProcess.Rows.Count > 0)
            {
                string filename = Path.Combine(Environment.CurrentDirectory, "dataclick.txt");
                using (var fw = new StreamWriter(filename, false))
                {
                    for (int i = 0; i < dgvProcess.Rows.Count; i++)
                    {
                        string row = string.Empty;
                        for (int j = 0; j < dgvProcess.ColumnCount; j++)
                        {
                            row += string.Format(";{0}", dgvProcess.Rows[i].Cells[j].Value.ToString());
                        }
                        row = row.Trim(';');
                        fw.WriteLine(row);
                    }
                    fw.Flush();
                    fw.Close();
                    fw.Dispose();
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvProcess.Rows.Clear();
            dgvProcess.Update();
            dgvProcess.Refresh();
        }
        private void btnShowProcess_Click(object sender, EventArgs e)
        {
            try
            {
                var processName = cmbProcess.Text;
                var AllProcess = Process.GetProcessesByName(processName);
                foreach (var process in AllProcess)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    WindowDisplayManager.ShowWindowAsync(hWnd, WindowDisplayManager.SW_SHOWMAXIMIZED);
                    WindowDisplayManager.SetForegroundWindow(hWnd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnInterval_Click(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(txtInterval.Text);
        }
    }
}
