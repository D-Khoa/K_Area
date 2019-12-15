using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeGame.Model;

namespace SnakeGame
{
    public partial class MainGame : Form
    {
        const int DIRECTION = 10;
        Queue<Point> snake = new Queue<Point>();
        Random random = new Random();
        Point direction;
        Point food;
        int cols, rows, w, h;

        public MainGame()
        {
            InitializeComponent();
            cols = 50;
            rows = 50;
            w = this.Width / cols;
            h = this.Height / rows;
            food = new Point(random.Next(50), random.Next(50));
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            CreateSnake();
            CreateFood();
            pnlMainBoard.Refresh();
        }

        private void CreateSnake()
        {
            Point p1 = new Point(random.Next(50), random.Next(50));
            Point p2 = new Point(p1.X - 1, p1.Y);
            Point p3 = new Point(p2.X - 1, p2.Y);
            snake.Enqueue(p1);
            snake.Enqueue(p2);
            snake.Enqueue(p3);
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
            }
        }

        private void CreateFood()
        {
            if (CheckFood())
                food = new Point(random.Next(50), random.Next(50));
        }

        private bool CheckFood()
        {
            foreach (Point p in snake)
            {
                if (food == p)
                    return false;
            }
            return true;
        }

        private void pnlMainBoard_Paint(object sender, PaintEventArgs e)
        {
            //for (int x = 0; x < this.Width; x += w)
            //{
            //    e.Graphics.DrawLine(new Pen(Color.Red), x, 0, x, this.Height);
            //}
            //for (int y = 0; y < this.Height; y += h)
            //{
            //    e.Graphics.DrawLine(new Pen(Color.Red), 0, y, this.Width, y);
            //}
            if (food != null)
            {
                foreach(Point p in snake)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Blue), p.X * w, p.Y * h, w, h);
                }
                e.Graphics.DrawEllipse(new Pen(Color.Blue), food.X * w, food.Y * h, w, h);
            }
        }
    }
}
