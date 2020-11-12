using BaseLibrary.Global;
using System.Drawing;

namespace BaseLibrary.Elements
{
    public abstract class BaseElement
    {
        #region ||PROPERTIES||
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public int NewX { get; private set; }
        public int NewY { get; private set; }
        public int NewZ { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool IsBlock { get; private set; }
        public int BorderSize { get; private set; }
        public Rectangle Rect { get; private set; }
        public Bitmap Sprites { get; private set; }
        public Color BackColor { get; private set; }
        public Brush ColorBrush { get; private set; }
        public ElementDirection Direction { get; private set; }
        #endregion

        public BaseElement(int x, int y, int witdh, int height)
        {
            X = x;
            Y = y;
            Width = witdh;
            Height = height;
            Rect = new Rectangle(X * Width, Y * Height, Width, Height);
        }

        public BaseElement(Color color, int x, int y, int z, int witdh, int height, int borderSize)
        {
            X = x;
            Y = y;
            Z = z;
            Width = witdh;
            Height = height;
            BackColor = color;
            BorderSize = borderSize;
            ColorBrush = new SolidBrush(color);
            Rect = new Rectangle(X * Width, Y * Height, Width - 2 * borderSize, Height - 2 * borderSize);
        }

        #region ||MOVEMENT||
        public void MoveUp()
        {
            NewX = X;
            NewY = Y - 1;
        }
        public void MoveDown()
        {
            NewX = X;
            NewY = Y + 1;
        }
        public void MoveLeft()
        {
            NewY = Y;
            NewX = X - 1;
        }
        public void MoveRight()
        {
            NewY = Y;
            NewX = X + 1;
        }
        public void MoveConfirm()
        {
            if (!IsBlock)
            {
                X = NewX;
                Y = NewY;
                Rect = new Rectangle(X * Width, Y * Height,
                    Width - 2 * BorderSize, Height - 2 * BorderSize);
            }
        }
        public void MoveLock(bool isBlock)
        {
            IsBlock = isBlock;
        }
        #endregion

        public void ChangeSize(int width, int height)
        {
            Width = width;
            Height = height;
            Rect = new Rectangle(X * Width, Y * Height,
                Width - 2 * BorderSize, Height - 2 * BorderSize);
        }

        public void ChangeLocation(int x, int y)
        {
            X = x;
            Y = y;
            Rect = new Rectangle(X * Width, Y * Height,
                Width - 2 * BorderSize, Height - 2 * BorderSize);
        }
    }
}
