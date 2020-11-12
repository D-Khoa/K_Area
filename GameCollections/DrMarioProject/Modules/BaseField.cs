using System.Drawing;

namespace DrMarioProject.Modules
{
    public abstract class BaseField
    {
        public Size Size { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public Size CellSize { get; private set; }
        public Point Location { get; private set; }
        public Rectangle Rect { get; private set; }
        public BaseField(Size size, Point location, int rows, int columns)
        {
            Size = size;
            Rows = rows;
            Columns = columns;
            Location = location;
            Rect = new Rectangle(location, size);
            int cellWidth = size.Width / columns;
            int cellHeight = size.Height / rows;
            CellSize = new Size(cellWidth, cellHeight);
        }
    }
}
