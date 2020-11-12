using DrMarioProject.Assets;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrMarioProject.Views
{
    public partial class UCBoardGame : UserControl
    {
        private MidCell _currentCell;
        public int Speed { get; private set; }
        private readonly Board20x20 _background;

        public UCBoardGame()
        {
            InitializeComponent();
            _background = new Board20x20(Width, Height);
            NewGame(100);
        }

        public void NewGame(int speed)
        {
            timerGameRun.Interval = timerGameRun.Interval * 100 / speed;
            for (int c = 0; c < _background.Columns; c++)
            {
                for (int r = 0; r < _background.Rows - 1; r++)
                {
                    _background.SetLowCells(new LowCell(c, r, _background.CellWidth, _background.CellHeight));
                }
                _background.SetMidCells(new MidCell(Color.Black, c, _background.Rows - 1,
                    _background.CellWidth, _background.CellHeight));
            }
            _currentCell = new MidCell(Color.Blue, 9, 0, _background.CellWidth, _background.CellHeight);
            timerGameRun.Enabled = true;
        }

        private void MoveCheck()
        {
            if (_currentCell.NewX > _background.Columns - 1 || _currentCell.NewX < 0
                || _currentCell.NewY > _background.Rows - 1 || _currentCell.NewY < 0)
            {
                return;
            }
            if(_background.MidCells.ContainsKey(_currentCell.NewY) 
                && _background.MidCells[_currentCell.NewY][_currentCell.NewX] != null)
            {
                _currentCell.MoveLock(true);
                _background.SetMidCells(_currentCell);
                _background.CheckRow(_currentCell.Y);
                _currentCell = new MidCell(Color.Blue, 9, 0, _background.CellWidth, _background.CellHeight);
            }
            else
            {
                _currentCell.MoveConfirm();
            }
            this.Refresh();
        }

        private void UCBoardGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    _currentCell.MoveUp();
                    break;
                case Keys.S:
                case Keys.Space:
                    _currentCell.MoveDown();
                    break;
                case Keys.A:
                    _currentCell.MoveLeft();
                    break;
                case Keys.D:
                    _currentCell.MoveRight();
                    break;
                default: break;
            }
            MoveCheck();
        }

        private void timerGameRun_Tick(object sender, EventArgs e)
        {
            _currentCell.MoveDown();
            MoveCheck();
        }

        private void UCBoardGame_Paint(object sender, PaintEventArgs e)
        {
            for (int r = 0; r < _background.LowCells.Count; r++)
            {
                if (_background.LowCells.ElementAt(r).Value != null)
                {
                    for (int c = 0; c < _background.LowCells.ElementAt(r).Value.Length; c++)
                    {
                        if (_background.LowCells.ElementAt(r).Value[c] != null)
                        {
                            e.Graphics.FillRectangle(_background.LowCells.ElementAt(r).Value[c].ColorBrush,
                                _background.LowCells.ElementAt(r).Value[c].Rect);
                        }
                    }
                }
            }
            for (int r = 0; r < _background.MidCells.Count; r++)
            {
                if (_background.MidCells.ElementAt(r).Value != null)
                {
                    for (int c = 0; c < _background.MidCells.ElementAt(r).Value.Length; c++)
                    {
                        if (_background.MidCells.ElementAt(r).Value[c] != null)
                        {
                            e.Graphics.FillRectangle(_background.MidCells.ElementAt(r).Value[c].ColorBrush,
                            _background.MidCells.ElementAt(r).Value[c].Rect);
                        }
                    }
                }
            }
            e.Graphics.FillRectangle(_currentCell.ColorBrush, _currentCell.Rect);
        }

        private void UCBoardGame_SizeChanged(object sender, EventArgs e)
        {
            _background.SetSize(Width, Height);
            _currentCell.ChangeSize(_background.CellWidth, _background.CellHeight);
            for (int r = 0; r < _background.LowCells.Count; r++)
            {
                if (_background.LowCells.ElementAt(r).Value != null)
                {
                    for (int c = 0; c < _background.LowCells.ElementAt(r).Value.Length; c++)
                    {
                        if (_background.LowCells.ElementAt(r).Value[c] != null)
                        {
                            _background.LowCells.ElementAt(r).Value[c]
                                .ChangeSize(_background.CellWidth, _background.CellHeight);
                        }
                    }
                }
            }
            for (int r = 0; r < _background.MidCells.Count; r++)
            {
                if (_background.MidCells.ElementAt(r).Value != null)
                {
                    for (int c = 0; c < _background.MidCells.ElementAt(r).Value.Length; c++)
                    {
                        if (_background.LowCells.ElementAt(r).Value[c] != null)
                        {
                            _background.LowCells.ElementAt(r).Value[c]
                                .ChangeSize(_background.CellWidth, _background.CellHeight);
                        }
                    }
                }
            }
            this.Refresh();
        }

        private void UCBoardGame_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    _currentCell.MoveUp();
                    break;
                case Keys.Down:
                    _currentCell.MoveDown();
                    break;
                case Keys.Left:
                    _currentCell.MoveLeft();
                    break;
                case Keys.Right:
                    _currentCell.MoveRight();
                    break;
                default: break;
            }
            MoveCheck();
        }
    }
}
