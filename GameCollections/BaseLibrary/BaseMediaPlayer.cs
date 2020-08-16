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
        /// <summary>
        /// Theme of media player
        /// </summary>
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
        /// <summary>
        /// Link music folder
        /// </summary>
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
        /// <summary>
        /// Set player state
        /// </summary>
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

        private bool _loadPlaylist;
        /// <summary>
        /// Load playlist
        /// </summary>
        public bool LoadPlaylist
        {
            get
            {
                return _loadPlaylist;
            }

            set
            {
                _loadPlaylist = value;
            }
        }

        private int _volume;
        /// <summary>
        /// Set volume
        /// </summary>
        public int Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                _volume = value;
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
            if (!_isplaying)
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
                _isplaying = true;
                mediaplayer.controls.play();
                timerPlaying.Enabled = true;
            }
            else
            {
                _isplaying = false;
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
            Volume = trbVolume.Value;
        }

        private void numVolume_ValueChanged(object sender, EventArgs e)
        {
            trbVolume.Value = (int)numVolume.Value;
            mediaplayer.settings.volume = trbVolume.Value;
            Volume = (int)numVolume.Value;
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_loadPlaylist)
            {
                #region GET MEDIA PLAY LIST
                if (!string.IsNullOrEmpty(_srcMusicURL))
                {
                    SrcMusic = new DirectoryInfo(_srcMusicURL);
                    CreatePlaylist();
                }
                #endregion
                _loadPlaylist = false;
            }
            numVolume.Value = (decimal)_volume;
            trbVolume.Value = _volume;
            mediaplayer.settings.volume = _volume;
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
