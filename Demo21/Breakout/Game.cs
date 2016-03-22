using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Breakout
{
    class Game
    {
        // Timer
        private DispatcherTimer timer;

        // Canvas
        private Canvas canvas;

        // Ball
        public Ball ball;

        // Paddle
        public Paddle paddle;

        // Blocks
        private List<Block> blocks;

        // Constructor
        public Game(Canvas canvas)
        {
            this.canvas = canvas;
            CreateBall();
            CreatePaddle();
            CreateBlocks();
        }

        // Add ball to game
        private void CreateBall()
        {
            ball = new Ball
            {
                LocationX = 390,
                LocationY = 500
            };
            canvas.Children.Add(ball);
        }

        // Add paddle to game

        private void CreatePaddle()
        {
            paddle = new Paddle
            {
                LocationX = 350,
                LocationY = 550
            };
            canvas.Children.Add(paddle);
        }

        // Add blocks to game

        private void CreateBlocks()
        {
            blocks = new List<Block>();
            int blocksCount = 120;
            int cols = 12;
            int xStartPos = 70;
            int yStartPos = 30;
            int step = 5;
            int row = 0;
            int col = 0;

            for (int i = 0; i < blocksCount ; i++)
            {
                // Is it a new row
                if (i % cols == 0 && i > 0)
                {
                    row++;
                    col = 0;
                }
                else if (i > 0)
                { col++; }

                // Block position
                int x = (50 + step) * col + xStartPos; // 0, 55, 110...
                int y = (20 + step) * row + yStartPos; // 0, 25, 50, 75...

                // Create a new block
                Block block = new Block
                {
                    LocationX = x,
                    LocationY = y
                };
                // Add to blocks
                blocks.Add(block); // List-collection
                // Add to canvas
                canvas.Children.Add(block);
                // Set location
                block.SetLocation();
            }
        }

        // Start game
        public void StartGame()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60); // 60 fps
            timer.Start();
        }
        
        // Game loop
        private void Timer_Tick(object sender, object e)
        {
            Debug.WriteLine("Game");
            ball.Move();
            CheckCollision();
            IsGameOver();
        }

        // Game Over
        private void IsGameOver()
        {
            // All blocks rekt
            if (blocks.Count == 0)
            {
                Debug.WriteLine("Game over - Good job!");
                timer.Stop();
            }
            // Ball below paddle
            if (ball.LocationY > paddle.LocationY)
            {
                Debug.WriteLine("Game over - Better luck next time!");
                timer.Stop();
            }
        }

        private void CheckCollision()
        {
            // Ball and paddle
            Rect rect = ball.GetRect();
            rect.Intersect(paddle.GetRect());
            if (!rect.IsEmpty)
            {
                // Paddle 100 px
                // ball position 0-100
                double ballPosition = ball.LocationX - paddle.LocationX;
                // -0.5 <-> 0.5
                double hitPercent = (ballPosition / paddle.Width) - 0.5;
                // Set ball speed
                ball.SetSpeed(hitPercent);
            }

            // Ball and blocks
            foreach(Block block in blocks)
            {
                Rect ballRect = ball.GetRect();
                ballRect.Intersect(block.GetRect());
                if (!ballRect.IsEmpty)
                {
                    // Remove block from list-collection
                    blocks.Remove(block);
                    // Remove from canvas
                    canvas.Children.Remove(block);
                    // Ball SpeedX and SpeedY?
                    double ballCenter = ball.LocationX + (ball.Width / 2);
                    if (ballCenter < block.LocationX || ballCenter > block.LocationX + block.Width)
                    {
                        ball.SpeedX *= -1;
                    } else
                    {
                        ball.SpeedY *= -1;
                    }
                    break;                    
                }
            }
        }

    }
}
