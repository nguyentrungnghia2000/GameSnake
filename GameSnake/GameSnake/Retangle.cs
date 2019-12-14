using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Retangle
    {
        public Color color { get; }
        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        int X, Y;
        int width, height;

        public Retangle(int x, int y, int w, int h, Color c)
        {
            X1 = x; Y1 = y;
            Width = w; Height = h;
            color = c;
        }

        public Rectangle Rectangle()
        {
            return new Rectangle(X, Y, Width, Height);
        }
    }
}
