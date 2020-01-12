using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollections
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"D:\GitHud\K_Area\GameCollections\GameCollections\Resources\Con Tuoi Nao Cho Em - Miu Le.mp3";
            player.controls.play();
        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
