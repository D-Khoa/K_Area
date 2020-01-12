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

        Snake setsnake;

        public MainGame()
        {
            InitializeComponent();
            dir = new Point(0, 0);
            w = pnlMain.Width;
            h = pnlMain.Height;
            cols = w / UNIT;
            rows = h / UNIT;
            score = 0;
            fps = 2;

            setsnake = new Snake(UNIT, cols, rows);
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            setsnake.AddSnake(new Point(w / 2, h / 2));
            CreateFood();
        }

        #region CONTROL & DRAWING EVENT
        /// <summary>
        /// Press keys for direction the snake
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Paint event draw the snake and food
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point p in snake)
            {
                e.Graphics.FillEllipse(brsnake, p.X, p.Y, 10, 10);
            }
            e.Graphics.FillEllipse(brfood, food.X, food.Y, 10, 10);
        }
        #endregion

        #region BACKGROUND WORKER SETUP
        /// <summary>
        /// Background worker control speed of game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (fps > 0)
                    Thread.Sleep(1000 / fps);
                else
                    Thread.Sleep(1000);
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
        #endregion

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
                if (s.X >= w)
                    s.X = 0;
                if (s.Y >= h)
                    s.Y = 0;
                if (s.X <= 0)
                    s.X = w;
                if (s.Y <= 0)
                    s.Y = h;
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
            foreach (Point p in setsnake.lenght)
            {
                if (p == k)
                {
                    goto CheckFood;
                }
            }
            food = k;
            pnlMain.Refresh();
        }

        #region MENU
        /// <summary>
        /// Get a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedTab = tab_GamePlay;
        }

        /// <summary>
        /// Show highscore board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHighScore_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show setting board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Exit game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
