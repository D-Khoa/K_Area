using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeGame.Model;

namespace SnakeGame
{
    public partial class MainGame : Form
    {
        const int UNIT = 10;
        Brush brsnake = new SolidBrush(Color.Red);
        Brush brfood = new SolidBrush(Color.Blue);
        List<Point> snake = new List<Point>();
        Random rand = new Random();
        Point food = new Point();
        Point dir = new Point();
        Point s0 = new Point();
        Point s = new Point();
        bool gameover = false;
        int w, h, cols, rows, fps;
        int score, highscore;

        public MainGame()
        {
            InitializeComponent();
            dir = new Point(0, 0);
            w = pnlMain.Width;
            h = pnlMain.Height;
            cols = w / UNIT;
            rows = h / UNIT;
            score = 0;
            fps = 30;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            AddSnake(new Point((cols / 2 - 2) * UNIT, h / 2));
            AddSnake(new Point((cols / 2 - 1) * UNIT, h / 2));
            AddSnake(new Point((cols / 2) * UNIT, h / 2));
            CreateFood();
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    dir.X = 0;
                    if (dir.Y != UNIT)
                        dir.Y = -UNIT;
                    break;
                case Keys.Down:
                    dir.X = 0;
                    if (dir.Y != -UNIT)
                        dir.Y = UNIT;
                    break;
                case Keys.Left:
                    if (dir.X != UNIT)
                        dir.X = -UNIT;
                    dir.Y = 0;
                    break;
                case Keys.Right:
                    if (dir.X != -UNIT)
                        dir.X = UNIT;
                    dir.Y = 0;
                    break;
                case Keys.P:
                    if (bwFPS.IsBusy)
                    {
                        bwFPS.CancelAsync();
                    }
                    break;
            }
            if (!bwFPS.IsBusy)
            {
                bwFPS.RunWorkerAsync();
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point p in snake)
            {
                e.Graphics.FillEllipse(brsnake, p.X, p.Y, 10, 10);
            }
            e.Graphics.FillEllipse(brfood, food.X, food.Y, 10, 10);
        }

        private void bwFPS_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!gameover)
            {
                if (bwFPS.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                bwFPS.ReportProgress(0);
                Thread.Sleep(fps * 10);
            }
        }

        private void bwFPS_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsStatus.Text = "PLAYING";
            tsScore.Text = score.ToString();
            tsFPS.Text = fps.ToString();
            SnakeMove();
        }

        private void bwFPS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                tsStatus.Text = "PAUSED";
            }
            else
                tsStatus.Text = "GAME OVER";
        }

        private void SnakeMove()
        {
            s = new Point(snake[0].X + dir.X, snake[0].Y + dir.Y);
            foreach (Point p in snake)
            {
                if (s == p)
                    gameover = true;
            }
            if (s == food)
            {
                AddSnake(s);
                score += 10;
                CreateFood();
            }
            else
            {
                if (s.X == this.Width)
                    s.X = 0;
                if (s.Y == this.Height)
                    s.Y = 0;
                for (int i = 0; i < snake.Count; i++)
                {
                    s0 = snake[i];
                    snake[i] = s;
                    s = s0;
                }
            }
            pnlMain.Refresh();
        }

        private void AddSnake(Point hs)
        {
            if (snake.Count == 0)
                snake.Add(hs);
            else
            {
                s = hs;
                for (int i = 0; i < snake.Count; i++)
                {
                    s0 = snake[i];
                    snake[i] = s;
                    s = s0;
                }
                snake.Add(s);
            }
            pnlMain.Refresh();
        }

        private void CreateFood()
        {
            CheckFood:
            int x = rand.Next(cols);
            int y = rand.Next(rows);
            Point k = new Point(x * UNIT, y * UNIT);
            foreach (Point p in snake)
            {
                if (p == k)
                {
                    goto CheckFood;
                }
            }
            food = k;
            pnlMain.Refresh();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void classicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
