using BaseLibrary.Global;
using System.Drawing;

namespace DrMarioProject.Modules
{
    public abstract class BaseElement
    {
        public Size Size { get; private set; }
        public int ZIndex { get; private set; }
        public bool IsLock { get; private set; }
        public Bitmap Image { get; private set; }
        public Point Location { get; private set; }
        public Point NewLocation { get; private set; }
        public Rectangle Rect { get; private set; }
        public Color BackColor { get; private set; }
        public Brush ColorBrush { get; private set; }
        public BaseElement(Color color, Size size, Point location, int zIndex)
        {
            Size = size;
            ZIndex = zIndex;
            BackColor = color;
            Location = location;
            ColorBrush = new SolidBrush(color);
            Image = new Bitmap(size.Width > 0 ? size.Width : 10, size.Height > 0 ? size.Height : 10);
            Rect = new Rectangle(location.X * size.Width, location.Y * size.Height, size.Width, size.Height);
        }
        public void MoveUp()
        {
            NewLocation = new Point(Location.X, Location.Y - 1);
        }
        public void MoveDown()
        {
            NewLocation = new Point(Location.X, Location.Y + 1);
        }
        public void MoveLeft()
        {
            NewLocation = new Point(Location.X - 1, Location.Y);
        }
        public void MoveRight()
        {
            NewLocation = new Point(Location.X + 1, Location.Y);
        }
        public void MoveConfirm()
        {
            if (IsLock) { return; }
            Location = NewLocation;
            Rect = new Rectangle(Location.X * Size.Width, Location.Y * Size.Height, Size.Width, Size.Height);
        }
        public void MoveLock(bool isLock)
        {
            IsLock = isLock;
        }
        public void SetImage(Image image)
        {
            using (Graphics e = Graphics.FromImage(Image))
            {
                e.DrawImage(image, new Point(0, 0));
                e.Dispose();
            }
        }
        public void SetSize(Size size)
        {
            Size = size;
            Rect = new Rectangle(Location.X * size.Width, Location.Y * size.Height, size.Width, size.Height);
        }
    }
}
