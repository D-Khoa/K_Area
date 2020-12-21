using BaseLibrary.Elements;
using System.Drawing;
using System.Linq;

namespace DrMarioProject.Assets
{
    public class MidCell : BaseElement
    {
        private bool _isMax;
        public MidCell(Color color, int x, int y, int width, int height)
            : base(color, x, y, 1, width, height, 1) { _isMax = false; }

        public MidCell[] LBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X,Y,Width,Height){ NewX = NewX, NewY = NewY},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X+1,Y+1,Width,Height){ NewX = NewX+1, NewY = NewY+1},
                new MidCell(BackColor, X+2,Y+1,Width,Height){ NewX = NewX+2, NewY = NewY+1}
            };
        }
        public MidCell[] JBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X+1,Y,Width,Height){ NewX = NewX+1, NewY = NewY},
                new MidCell(BackColor, X+1,Y+1,Width,Height){ NewX = NewX+1, NewY = NewY+1},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X-1,Y+1,Width,Height){ NewX = NewX-1, NewY = NewY+1}
            };
        }
        public MidCell[] OBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X,Y,Width,Height){ NewX = NewX, NewY = NewY},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X+1,Y,Width,Height){ NewX = NewX+1, NewY = NewY},
                new MidCell(BackColor, X+1,Y+1,Width,Height){ NewX = NewX+1, NewY = NewY+1}
            };
        }
        public MidCell[] IBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X,Y-1,Width,Height){ NewX = NewX, NewY = NewY-1},
                new MidCell(BackColor, X,Y,Width,Height){ NewX = NewX, NewY = NewY},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X,Y+2,Width,Height){ NewX = NewX, NewY = NewY+2}
            };
        }
        public MidCell[] TBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X,Y,Width,Height){ NewX = NewX, NewY = NewY},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X-1,Y+1,Width,Height){ NewX = NewX-1, NewY = NewY+1},
                new MidCell(BackColor, X+1,Y+1,Width,Height){ NewX = NewX+1, NewY = NewY+1}
            };
        }
        public MidCell[] ZBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X,Y,Width,Height){ NewX = NewX, NewY = NewY},
                new MidCell(BackColor, X-1,Y,Width,Height){ NewX = NewX-1, NewY = NewY},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X+1,Y+1,Width,Height){ NewX = NewX+1, NewY = NewY+1}
            };
        }
        public MidCell[] SBlock()
        {
            return new MidCell[]
            {
                new MidCell(BackColor, X,Y,Width,Height){ NewX = NewX, NewY = NewY},
                new MidCell(BackColor, X+1,Y,Width,Height){ NewX = NewX+1, NewY = NewY},
                new MidCell(BackColor, X,Y+1,Width,Height){ NewX = NewX, NewY = NewY+1},
                new MidCell(BackColor, X-1,Y+1,Width,Height){ NewX = NewX-1, NewY = NewY+1}
            };
        }

        public MidCell[] Rotate(MidCell[] block)
        {
            if (_isMax) return block;
            return block.Select(x => new MidCell(BackColor, x.Y - Y, (X + 4) - x.X, Width, Height)
                                                { NewX = x.NewY - NewY, NewY = (NewX + 4) - x.NewX }).ToArray();
        }

        public void SetMax(bool isMax)
        {
            _isMax = isMax;
        }
    }
}
