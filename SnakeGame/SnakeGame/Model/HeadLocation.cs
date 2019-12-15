using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Model
{
    struct HeadLocation
    {
        int x;
        int y;
        int x0;
        int y0;
    }

    struct Food
    {
        int x;
        int y;
    }

    struct HighScore
    {
        string name;
        int score;
    }
}
