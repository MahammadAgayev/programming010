using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace programming011.snake
{

    public partial class frmMain : Form
    {
        private readonly GameConfiguration _gameConfiguration;

        private List<Circle> _snake = new List<Circle>();
        private Circle _food;

        private System.Timers.Timer _timer;

        private int _currentDirection;
        private bool _gameOver = true;

        public frmMain()
        {
            InitializeComponent();

            _gameConfiguration = new GameConfiguration
            {
                Width = 20,
                Height = 20,
                RefreshIntervalSeconds = 0.2
            };

            _timer = new System.Timers.Timer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _timer.Elapsed += TimerElapsed;
            _timer.Interval = _gameConfiguration.RefreshIntervalSeconds * 1000;

            StartGame();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_gameOver)
            {
                pnlGameBoard.Invalidate();
                return;
            }

            Circle head = _snake[0];

            for (int i = _snake.Count - 1; i > 0; i--)
            {
                _snake[i].X = _snake[i - 1].X;
                _snake[i].Y = _snake[i - 1].Y;
            }

            switch (_currentDirection)
            {
                case Directions.Right:
                    head.X += _gameConfiguration.Width;
                    break;
                case Directions.Left:
                    head.X -= _gameConfiguration.Width;
                    break;
                case Directions.Up:
                    head.Y -= _gameConfiguration.Height;
                    break;
                case Directions.Down:
                    head.Y += _gameConfiguration.Height;
                    break;
            }


            CheckCollision(head);
            CheckAndReEnter(head);
            CheckAndEat(head);

            pnlGameBoard.Invalidate();
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {
            if (_gameOver)
            {
                GameOver();
            }

            Graphics g = e.Graphics;

            foreach (Circle item in _snake)
            {
                g.FillEllipse(Brushes.Red, GetRectangle(item));
            }

            g.FillEllipse(Brushes.Red, GetRectangle(_food));
        }


        private RectangleF GetRectangle(Circle c)
        {
            return new RectangleF(c.X, c.Y, _gameConfiguration.Width, _gameConfiguration.Height);
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down when _currentDirection != Directions.Up:
                    _currentDirection = Directions.Down;
                    break;
                case Keys.Up when _currentDirection != Directions.Down:
                    _currentDirection = Directions.Up;
                    break;
                case Keys.Left when _currentDirection != Directions.Right:
                    _currentDirection = Directions.Left;
                    break;
                case Keys.Right when _currentDirection != Directions.Left:
                    _currentDirection = Directions.Right;
                    break;
                case Keys.Space when _gameOver:
                    StartGame();
                    break;
            }
        }


        private void GenerateFood()
        {
            Random rand = new Random();

            int panelWidth = pnlGameBoard.Width / _gameConfiguration.Width;
            int panelHeight = pnlGameBoard.Height / _gameConfiguration.Height;

            int randX = rand.Next(0, panelWidth);
            int randY = rand.Next(0, panelHeight);

            _food = new Circle
            {
                X = randX * _gameConfiguration.Width,
                Y = randY * _gameConfiguration.Height,
            };
        }

        private void CheckAndEat(Circle head)
        {
            if (head.X == _food.X && head.Y == _food.Y)
            {
                _snake.Add(new Circle
                {
                    X = head.X,
                    Y = head.Y
                });

                GenerateFood();
            }
        }

        private void CheckCollision(Circle head)
        {
            for (int i = 1; i < _snake.Count; i++)
            {
                if (head.X == _snake[i].X && head.Y == _snake[i].Y)
                {
                    _gameOver = true;
                }
            }
        }

        private void GameOver()
        {
            lblGameOver.Visible = true;
            _timer.Enabled = false;
        }

        private void StartGame()
        {
            _gameOver = false;
            lblGameOver.Visible = false;

            _snake.Clear();

            _snake.Add(new Circle
            {
                X = 0,
                Y = 0
            });
            _currentDirection = Directions.Right;

            GenerateFood();

            _timer.Enabled = true;
        }

        private void CheckAndReEnter(Circle head)
        {
            if (head.X > pnlGameBoard.Width)
            {
                head.X = 0;
            }
            else if (head.X < 0)
            {
                head.X = (pnlGameBoard.Width / _gameConfiguration.Width) * _gameConfiguration.Width;
            }
            else if (head.Y > pnlGameBoard.Height)
            {
                head.Y = 0;
            }
            else if (head.Y < 0)
            {
                head.Y = (pnlGameBoard.Height / _gameConfiguration.Height) * _gameConfiguration.Height;
            }
        }
    }
}
