using BaseLibrary.Global;
using DrMarioProject.Assets;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrMarioProject.Views
{
    public partial class UCBoardGame : UserControl
    {
        private Pen _borderPen;
        private MidCell _currentCell;
        private MidCell[] _currentBlock;
        private TerrikBlock _terrikBlock;
        public int Speed { get; private set; }
        private readonly Board20x20 _background;

        public UCBoardGame()
        {
            InitializeComponent();
            _background = new Board20x20(Width - 1, Height - 1);
            _borderPen = new Pen(Color.Black);
            NewGame(100);
        }

        public void NewGame(int speed)
        {
            timerGameRun.Interval = timerGameRun.Interval * 100 / speed;
            timerGameRun.Enabled = true;
            NewBlock();
        }

        public void NewBlock()
        {
            Random ran = new Random();
            int blockIndex = ran.Next(0, 4);
            _terrikBlock = (TerrikBlock)blockIndex;
            _currentCell = new MidCell(Color.Blue, 4, 0, _background.CellWidth, _background.CellHeight);
            switch (_terrikBlock)
            {
                case TerrikBlock.I:
                    _currentBlock = _currentCell.IBlock();
                    break;
                case TerrikBlock.L:
                    _currentBlock = _currentCell.LBlock();
                    break;
                case TerrikBlock.T:
                    _currentBlock = _currentCell.TBlock();
                    break;
                case TerrikBlock.O:
                    _currentBlock = _currentCell.OBlock();
                    break;
                case TerrikBlock.S:
                    _currentBlock = _currentCell.SBlock();
                    break;
                case TerrikBlock.Z:
                    _currentBlock = _currentCell.ZBlock();
                    break;
                default: break;
            }
        }

        private void MoveCheck()
        {
            _currentCell.SetMax(false);
            if (_currentBlock.Any(x=>x.NewX > _background.Columns - 1 || x.NewX < 0 || x.NewY < 0))
            {
                _currentCell.SetMax(true);
                return;
            }
            if (_currentBlock.Any(x => x.NewY > _background.Rows - 1
             || _background.Cells.ContainsKey(x.NewY)
             && _background.Cells[x.NewY][x.NewX] != null))
            {
                for (int i = 0; i < _currentBlock.Length; i++)
                {
                    _currentBlock[i].MoveLock(true);
                    _background.SetCells(_currentBlock[i]);
                }
                _background.CheckRow();
                NewBlock();
            }
            else
            {
                for (int i = 0; i < _currentBlock.Length; i++)
                {
                    _currentBlock[i].MoveConfirm();
                }
            }
            this.Refresh();
        }

        private void UCBoardGame_KeyDown(object sender, KeyEventArgs e)
        {
            string direction = "DOWN";
            switch (e.KeyData)
            {
                case Keys.W:
                    direction = "UP";
                    break;
                case Keys.S:
                    direction = "DOWN";
                    break;
                case Keys.A:
                    direction = "LEFT";
                    break;
                case Keys.D:
                    direction = "RIGHT";
                    break;
                case Keys.Space:
                    _currentBlock = _currentCell.Rotate(_currentBlock);
                    return;
                default: break;
            }
            for (int i = 0; i < _currentBlock.Length; i++)
            {
                _currentBlock[i].MoveCommand(direction);
            }
            MoveCheck();
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

        private void timerGameRun_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _currentBlock.Length; i++)
            {
                _currentBlock[i].MoveCommand("DOWN");
            }
            MoveCheck();
        }

        private void UCBoardGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(_borderPen, _background.Border);
            for (int r = 0; r < _background.Cells.Count; r++)
            {
                if (_background.Cells.ElementAt(r).Value != null)
                {
                    //e.Graphics.DrawRectangles(_borderPen,
                    //    _background.Cells.ElementAt(r).Value
                    //    .Where(x => x != null).Select(x => x.Border).ToArray());
                    e.Graphics.FillRectangles(_currentCell.ColorBrush, _background.Cells.ElementAt(r).Value
                        .Where(x => x != null).Select(x => x.Rect).ToArray());
                }
            }
            e.Graphics.FillRectangles(_currentCell.ColorBrush, _currentBlock.Select(x => x.Rect).ToArray());
        }

        private void UCBoardGame_SizeChanged(object sender, EventArgs e)
        {
            _background.SetSize(Width - 1, Height - 1);
            _currentCell.ChangeSize(_background.CellWidth, _background.CellHeight);
            for (int i = 0; i < _currentBlock.Length; i++)
            {
                _currentBlock[i].ChangeSize(_background.CellWidth, _background.CellHeight);
            }
            for (int r = 0; r < _background.Cells.Count; r++)
            {
                if (_background.Cells.ElementAt(r).Value != null)
                {
                    for (int c = 0; c < _background.Cells.ElementAt(r).Value.Length; c++)
                    {
                        if (_background.Cells.ElementAt(r).Value[c] != null)
                        {
                            _background.Cells.ElementAt(r).Value[c]
                                .ChangeSize(_background.CellWidth, _background.CellHeight);
                        }
                    }
                }
            }
            this.Refresh();
        }
    }
}
