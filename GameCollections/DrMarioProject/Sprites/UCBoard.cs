using DrMarioProject.Modules;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrMarioProject.Sprites
{
    public partial class UCBoard : UserControl
    {
        public int Speed { get; set; }
        private BackGroundBoard _board;
        private BlueAllyElement _currentAlly;
        private List<BaseElement> _cells;
        public UCBoard()
        {
            InitializeComponent();

        }

        public void NewGame()
        {
            _cells = new List<BaseElement>();
            _board = new BackGroundBoard(this.Size, new Point(0, 0));
            _currentAlly = new BlueAllyElement(_board.CellSize, new Point(9, 0));
            for (int c = 0; c < _board.Columns; c++)
            {
                for (int r = 0; r < _board.Rows - 1; r++)
                {
                    _cells.Add(new BackGroundElement(_board.CellSize, new Point(c, r)));
                }
                _cells.Add(new RedEnemyElement(_board.CellSize, new Point(c, 19)));
            }
        }

        private void UCBoard_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < _cells.Count; i++)
            {
                e.Graphics.FillRectangle(_cells[i].ColorBrush, _cells[i].Rect);
            }
            e.Graphics.FillRectangle(_currentAlly.ColorBrush, _currentAlly.Rect);
        }

        private void UCBoard_Resize(object sender, System.EventArgs e)
        {
            _board = new BackGroundBoard(this.Size, new Point(0, 0));
            _currentAlly = new BlueAllyElement(_board.CellSize, _currentAlly.Location);
            for (int i = 0; i < _cells.Count; i++)
            {
                _cells[i].SetSize(_board.CellSize);
            }
            this.Refresh();
        }

        private void UCBoard_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //case Keys.W:
                //    _currentAlly.MoveUp();
                //    break;
                case Keys.S:
                    _currentAlly.MoveDown();
                    break;
                case Keys.A:
                    _currentAlly.MoveLeft();
                    break;
                case Keys.D:
                    _currentAlly.MoveRight();
                    break;
                default: break;
            }
            MoveToNextCell();
        }

        private void timerMoveDown_Tick(object sender, System.EventArgs e)
        {
            _currentAlly.MoveDown();
            MoveToNextCell();
        }
        private void MoveToNextCell()
        {
            var nextCell = _cells.Last(x => x.Location == _currentAlly.NewLocation);
            if (nextCell.ZIndex == 1)
            {
                if (nextCell.Location.Y == 1)
                {
                    timerMoveDown.Stop();
                    MessageBox.Show("GAME OVER!");
                }
                _cells.Add(_currentAlly);
                _currentAlly.MoveLock(true);
                _currentAlly = new BlueAllyElement(_board.CellSize, new Point(9, 0));
            }
            else
            {
                _currentAlly.MoveConfirm();
            }
            this.Refresh();
        }
    }
}
