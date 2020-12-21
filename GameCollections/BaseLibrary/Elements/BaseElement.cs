using System.Drawing;

namespace BaseLibrary.Elements
{
    public abstract class BaseElement
    {
        #region ||PROPERTIES||
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public int NewX { get; set; }
        public int NewY { get; set; }
        public int NewZ { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool IsBlock { get; private set; }
        public int BorderSize { get; private set; }
        public Rectangle Rect { get; private set; }
        public Rectangle Border { get; private set; }
        public Bitmap Sprites { get; private set; }
        public Color BackColor { get; private set; }
        public Brush ColorBrush { get; private set; }
        #endregion

        public BaseElement(int x, int y, int witdh, int height)
        {
            X = x;
            Y = y;
            Width = witdh;
            Height = height;
            BorderSize = 0;
            Update();
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
            Update();
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
        public void MoveCommand(string direction)
        {
            switch (direction)
            {
                case "UP":
                    MoveUp();
                    break;
                case "DOWN":
                    MoveDown();
                    break;
                case "LEFT":
                    MoveLeft();
                    break;
                case "RIGHT":
                    MoveRight();
                    break;
                default:
                    break;
            }
        }
        public void MoveConfirm()
        {
            if (!IsBlock)
            {
                X = NewX;
                Y = NewY;
                Update();
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
            Update();
        }

        public void ChangeLocation(int x, int y)
        {
            X = x;
            Y = y;
            Update();
        }

        public void Update()
        {
            Border = new Rectangle(X * Width, Y * Height, Width, Height);
            Rect = new Rectangle(X * Width + BorderSize, Y * Height + BorderSize,
                Width - 2 * BorderSize, Height - 2 * BorderSize);
        }
    }
}
