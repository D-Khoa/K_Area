using System.Collections.Generic;

namespace BaseLibrary.Elements
{
    public abstract class BaseBackground
    {
        #region ||PROPERTIES||
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int BorderSize { get; private set; }
        public int CellWidth { get; private set; }
        public int CellHeight { get; private set; }
        public Dictionary<int, BaseElement[]> LowCells { get; private set; }
        public Dictionary<int, BaseElement[]> MidCells { get; private set; }
        public Dictionary<int, BaseElement[]> HighCells { get; private set; }

        #endregion

        public BaseBackground(int width, int height, int rows, int columns)
        {
            Rows = rows;
            Width = width;
            Height = height;
            Columns = columns;
            CellHeight = height / rows;
            CellWidth = width / columns;
            LowCells = new Dictionary<int, BaseElement[]>();
            MidCells = new Dictionary<int, BaseElement[]>();
            HighCells = new Dictionary<int, BaseElement[]>();
        }

        public void SetLowCells(BaseElement cell)
        {
            if (!LowCells.ContainsKey(cell.Y))
            {
                LowCells.Add(cell.Y, new BaseElement[Columns]);
            }
            LowCells[cell.Y][cell.X] = cell;
        }

        public void SetMidCells(BaseElement cell)
        {
            if (!MidCells.ContainsKey(cell.Y))
            {
                MidCells.Add(cell.Y, new BaseElement[Columns]);
            }
            MidCells[cell.Y][cell.X] = cell;
        }

        public void SetHighCells(BaseElement cell)
        {
            if (!HighCells.ContainsKey(cell.Y))
            {
                HighCells.Add(cell.Y, new BaseElement[Columns]);
            }
            HighCells[cell.Y][cell.X] = cell;
        }

        public void SetSize(int width, int height)
        {
            Width = width;
            Height = height;
            CellHeight = height / Rows;
            CellWidth = width / Columns;
        }
    }
}
