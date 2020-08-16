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
using GameCollections.Flags;

namespace GameCollections
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            tc_Main.ItemSize = new Size(0, 1);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        #region MENU BUTTONS
        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_Setting;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region SETTING BUTTONS
        private void btnSetApply_Click(object sender, EventArgs e)
        {
            SettingFlag.SoundFlag = rbtnSoundOn.Checked;
            SettingFlag.SoundVolFlag = trbSoundVol.Value;
            SettingFlag.MusicFlag = wmpMusicCollection.Isplaying;
            SettingFlag.MusicVolFlag = wmpMusicCollection.Volume;
            this.Width = int.Parse(cmbGraphic.Text.Split('x')[0]);
            this.Height = int.Parse(cmbGraphic.Text.Split('x')[1]);
            this.StartPosition = FormStartPosition.CenterScreen;
            tc_Main.SelectedTab = tab_Menu;
        }

        private void btnSetBack_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_Menu;
        }

        private void trbSoundVol_Scroll(object sender, EventArgs e)
        {
            numSoundVol.Value = (decimal)trbSoundVol.Value;
        }

        private void numSoundVol_ValueChanged(object sender, EventArgs e)
        {
            trbSoundVol.Value = (int)numSoundVol.Value;
        }

        private void btnBrowserMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofm = new OpenFileDialog
            {
                FileName = "Select Music Folder",
                ReadOnlyChecked = true,
                CheckFileExists = false,
                CheckPathExists = false,
            };
            if (ofm.ShowDialog() == DialogResult.OK)
                txtMusicFolder.Text = Path.GetDirectoryName(ofm.FileName);
        }

        private void txtMusicFolder_TextChanged(object sender, EventArgs e)
        {
            wmpMusicCollection.SrcMusicURL = txtMusicFolder.Text;
            wmpMusicCollection.LoadPlaylist = true;
            wmpMusicCollection.Isplaying = SettingFlag.MusicFlag;
            wmpMusicCollection.Volume = SettingFlag.MusicVolFlag;
        }
        #endregion
    }
}
