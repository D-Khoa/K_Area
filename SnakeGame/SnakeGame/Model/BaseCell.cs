using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame.Model
{
    public static class BaseCell
    {
        public static int cols { get; set; }
        public static int rows { get; set; }
        public static int w { get; set; }
        public static int h { get; set; }

        public static Rectangle Cell(int x, int y)
        {
            return new Rectangle(x, y, w, h);
        }
    }
}
