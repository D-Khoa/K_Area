using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace BaseLibrary
{
    public partial class BaseMediaPlayer : UserControl
    {
        #region GET SOURCE IMAGE & PLAY LIST FOLDER
        private Image _srcImage;
        public Image SrcImage
        {
            get
            {
                return _srcImage;
            }

            set
            {
                _srcImage = value;
                Invalidate();
            }
        }

        private string _srcMusicURL;
        public string SrcMusicURL
        {
            get
            {
                return _srcMusicURL;
            }

            set
            {
                _srcMusicURL = value;
                Invalidate();
            }
        }

        private bool _isplaying;
        public bool Isplaying
        {
            get
            {
                return _isplaying;
            }

            set
            {
                _isplaying = value;
                Invalidate();
            }
        }
        #endregion

        #region VARIABLE
        int w, h;
        Rectangle rectPlay;
        Rectangle rectNext;
        Rectangle rectStop;
        Rectangle rectPause;
        Rectangle rectSound;
        Rectangle rectNoSound;
        DirectoryInfo SrcMusic;
        WindowsMediaPlayer mediaplayer;
        #endregion

        public BaseMediaPlayer()
        {
            InitializeComponent();
            timerPlaying.Enabled = false;
            mediaplayer = new WindowsMediaPlayer();
            trbVolume.Value = (int)numVolume.Value;
            mediaplayer.settings.volume = trbVolume.Value;
        }

        private void BaseMediaPlayer_Load(object sender, EventArgs e)
        {
            #region GET SOURCE IMAGE FOR ALL BUTTON
            if (SrcImage != null)
            {
                w = SrcImage.Width / 6;
                h = SrcImage.Height;
                rectPlay = new Rectangle(0, 0, w, h);
                rectPause = new Rectangle(w, 0, w, h);
                rectStop = new Rectangle(w * 2, 0, w, h);
                rectNext = new Rectangle(w * 3, 0, w, h);
                rectSound = new Rectangle(w * 4, 0, w, h);
                rectNoSound = new Rectangle(w * 5, 0, w, h);
                btnPlay.SrcImage = CutFrame(w, h, rectPlay);
                btnNext.SrcImage = CutFrame(w, h, rectNext);
                btnStop.SrcImage = CutFrame(w, h, rectStop);
                if (trbVolume.Value == 0)
                    btnSound.SrcImage = CutFrame(w, h, rectNoSound);
                else
                    btnSound.SrcImage = CutFrame(w, h, rectSound);
            }
            #endregion

            #region GET MEDIA PLAY LIST
            if (!string.IsNullOrEmpty(SrcMusicURL))
            {
                SrcMusic = new DirectoryInfo(SrcMusicURL);
                CreatePlaylist();
            }
            #endregion
        }

        /// <summary>
        /// Get Source Image Frame For Each Button
        /// </summary>
        /// <param name="w">Frame Width</param>
        /// <param name="h">Frame Height</param>
        /// <param name="rect">Frame Rect</param>
        /// <returns></returns>
        private Image CutFrame(int w, int h, Rectangle rect)
        {
            Bitmap img = new Bitmap(w, h);
            Graphics cutFrame = Graphics.FromImage(img);
            cutFrame.DrawImage(SrcImage, new Rectangle(0, 0, w, h), rect, GraphicsUnit.Pixel);
            return img;
        }

        /// <summary>
        /// Create a playlist
        /// </summary>
        private void CreatePlaylist()
        {
            if (SrcMusic != null)
            {
                IWMPPlaylist playlist = mediaplayer.playlistCollection.newPlaylist("MyPlayList");
                FileInfo[] files = SrcMusic.GetFiles("*.mp3", SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                {
                    string musicfile = file.FullName;
                    IWMPMedia mediaitem = mediaplayer.newMedia(musicfile);
                    playlist.appendItem(mediaitem);
                }
                timerPlaying.Enabled = true;
                mediaplayer.currentPlaylist = playlist;
                btnPlay.SrcImage = CutFrame(w, h, rectPause);
            }
        }

        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            if (!Isplaying)
                mediaplayer.controls.pause();
            if (trbVolume.Value == 0)
                mediaplayer.settings.mute = true;
            else
                mediaplayer.settings.mute = false;
            Refresh();
        }
        #region MEADIA BUTTON ABILITY
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!timerPlaying.Enabled)
            {
                mediaplayer.controls.play();
                timerPlaying.Enabled = true;
            }
            else
            {
                mediaplayer.controls.pause();
                timerPlaying.Enabled = false;
            }
            Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mediaplayer.controls.next();
            Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mediaplayer.controls.stop();
            timerPlaying.Enabled = false;
            Refresh();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (mediaplayer.settings.mute)
                mediaplayer.settings.mute = false;
            else
                mediaplayer.settings.mute = true;
            Refresh();
        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            numVolume.Value = trbVolume.Value;
            mediaplayer.settings.volume = trbVolume.Value;
        }

        private void numVolume_ValueChanged(object sender, EventArgs e)
        {
            trbVolume.Value = (int)numVolume.Value;
            mediaplayer.settings.volume = trbVolume.Value;
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (timerPlaying.Enabled)
            {
                lbMediaName.Text = mediaplayer.currentMedia.name;
                lbTime.Text = mediaplayer.controls.currentPositionString + "/" + mediaplayer.currentMedia.durationString;
                btnPlay.SrcImage = CutFrame(w, h, rectPause);
            }
            else
                btnPlay.SrcImage = CutFrame(w, h, rectPlay);
            if (mediaplayer.settings.mute)
                btnSound.SrcImage = CutFrame(w, h, rectNoSound);
            else
                btnSound.SrcImage = CutFrame(w, h, rectSound);
            btnPlay.Refresh();
            btnSound.Refresh();
        }
    }
}
