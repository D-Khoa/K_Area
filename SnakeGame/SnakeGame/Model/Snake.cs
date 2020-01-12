using System.Drawing;
using System.Collections.Generic;

namespace SnakeGame.Model
{
    public class Snake
    {
        /// <summary>
        /// Current coordinate of the Snake
        /// </summary>
        public Point coor_curr { get; set; }

        /// <summary>
        /// Last coordinate of the Snake
        /// </summary>
        public Point coor_last { get; set; }

        /// <summary>
        /// Minimum element of snake
        /// </summary>
        public int element { get; set; }

        /// <summary>
        /// Location of the wall x-coor
        /// </summary>
        public int wall_x { get; set; }

        /// <summary>
        /// Location of the wall y-coor
        /// </summary>
        public int wall_y { get; set; }

        /// <summary>
        /// Lenght of the snake
        /// </summary>
        public List<Point> lenght { get; set; }

        /// <summary>
        /// New Snake
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Snake(int unit, int cols, int rows)
        {
            element = unit;
            wall_x = cols;
            wall_y = rows;
            lenght = new List<Point>();
        }

        /// <summary>
        /// Add element to snake
        /// </summary>
        /// <param name="coor_new"></param>
        public void AddSnake(Point coor_new)
        {
            if (lenght.Count == 0)
            {
                lenght.Add(coor_new);
                lenght.Add(new Point(coor_new.X - element, coor_new.Y));
                lenght.Add(new Point(coor_new.X - (2 * element), coor_new.Y));
            }
            else
            {
                coor_curr = coor_new;
                for (int i = 0; i < lenght.Count; i++)
                {
                    coor_last = lenght[i];
                    lenght[i] = coor_curr;
                    coor_curr = coor_last;
                }
                lenght.Add(coor_curr);
            }
        }

        /// <summary>
        /// The Snake move to direction
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool SnakeMove(Point direction)
        {
            coor_curr = new Point(lenght[0].X + direction.X, lenght[0].Y + direction.Y);
            if (coor_curr.X <= 0)
                coor_curr = new Point(wall_x, lenght[0].Y + direction.Y);
            if (coor_curr.X >= wall_x)
                coor_curr = new Point(0, lenght[0].Y + direction.Y);
            if (coor_curr.Y <= 0)
                coor_curr = new Point(lenght[0].X + direction.X, wall_y);
            if (coor_curr.X <= 0)
                coor_curr = new Point(lenght[0].X + direction.X, 0);
            foreach (Point p in lenght)
            {
                if (coor_curr == p)
                    return false;
            }
            for (int i = 0; i < lenght.Count; i++)
            {
                coor_last = lenght[i];
                lenght[i] = coor_curr;
                coor_curr = coor_last;
            }
            return true;
        }

        /// <summary>
        /// The snake eat food
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool EatFood(Point food)
        {
            if (lenght[0] == food)
            {
                AddSnake(food);
                return true;
            }
            return false;
        }
    }
}
