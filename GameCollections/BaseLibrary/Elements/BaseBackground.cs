using System;
using System.Collections.Generic;
using System.Drawing;

namespace BaseLibrary.Elements
{
    public abstract class BaseBackground
    {
        #region ||PROPERTIES||
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int BorderSize { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int CellWidth { get; private set; }
        public int CellHeight { get; private set; }
        public Rectangle Rect { get; private set; }
        public Rectangle Border { get; private set; }
        public Dictionary<int, BaseElement[]> Cells { get; private set; }
        #endregion

        public BaseBackground(int width, int height, int rows, int columns)
        {
            Rows = rows;
            Width = width;
            BorderSize = 0;
            Height = height;
            Columns = columns;
            Cells = new Dictionary<int, BaseElement[]>();
            Update();
        }

        public BaseBackground(int width, int height, int rows, int columns, int borderSize)
        {
            Rows = rows;
            Width = width;
            Height = height;
            Columns = columns;
            BorderSize = borderSize;
            Cells = new Dictionary<int, BaseElement[]>();
            Update();
        }

        public void SetCells(BaseElement cell)
        {
            if (!Cells.ContainsKey(cell.Y))
            {
                Cells.Add(cell.Y, new BaseElement[Columns]);
            }
            Cells[cell.Y][cell.X] = cell;
            Update();
        }

        public void SetSize(int width, int height)
        {
            Width = width;
            Height = height;
            Update();
        }

        public void Update()
        {
            CellHeight = Math.Min((Height / Rows), (Width / Columns));
            CellWidth = CellHeight;
            Height = CellHeight * Rows;
            Width = CellWidth * Columns;
            Border = new Rectangle(0, 0, Width, Height);
            Rect = new Rectangle(BorderSize, BorderSize, Width - 2 * BorderSize, Height - 2 * BorderSize);
        }
    }
}
