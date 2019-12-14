using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameSnake
{
    class Snake
    {
        private Rectangle[] snakeRec;
        public SolidBrush brush;
        int x, y, w, h;
        Random rand = new Random();

        public Rectangle[] SnakeRec { get => snakeRec; set => snakeRec = value; }
        #region DrawSnake
        public Snake()
        {
            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.Purple);
            w = 10; h = 10;
            x = rand.Next(20, 550);
            y = rand.Next(120, 380);
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, w, h);
                x -= 10;
            }
        }

        public void DrawSnake(Graphics g)
        {
            foreach (Rectangle rec in SnakeRec)
            {
                g.FillRectangle(brush, rec);
            }

            g.FillRectangle(new SolidBrush(Color.Red), SnakeRec[0]);
        }
        #endregion

        #region SnakeMove
        public void SnakeRun()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        public void MoveDown()
        {
            SnakeRun();
            snakeRec[0].Y += 10;
        }

        public void MoveUp()
        {
            SnakeRun();
            snakeRec[0].Y -= 10;
        }

        public void MoveLeft()
        {
            SnakeRun();
            snakeRec[0].X -= 10;
        }

        public void MoveRight()
        {
            SnakeRun();
            snakeRec[0].X += 10;
        }

        #endregion

        public void GrowSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, w, h));
            snakeRec = rec.ToArray();
        } // tự động lớn


    }
}
