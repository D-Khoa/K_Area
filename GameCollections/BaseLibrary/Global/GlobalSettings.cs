using System.Drawing;

namespace BaseLibrary.Global
{
    public class GlobalSettings
    {
        private GlobalSettings() { }
        public static GlobalSettings Options { get; } = new GlobalSettings();
        public int Volume { get; private set; }
        public string Music { get; private set; }
        public Size Graphics { get; private set; }
        public Difficult GameMode { get; private set; }

        public void VolumeUp()
        {
            Volume++;
        }
        public void VolumeDown()
        {
            Volume--;
        }
        public void SetVolume(int volume)
        {
            Volume = volume;
        }

        public void SetGraphic(Size graphicSize)
        {
            Graphics = graphicSize;
        }
        public void SetGraphic(int width, int height)
        {
            Graphics = new Size(width, height);
        }

        public void SetMusic(string music)
        {
            Music = music;
        }

        public void SetGameMode(Difficult difficult)
        {
            GameMode = difficult;
        }

        public void SetOptions(GlobalSettings global)
        {
            Music = global.Music;
            Volume = global.Volume;
            GameMode = global.GameMode;
            Graphics = global.Graphics;
        }
    }
}
