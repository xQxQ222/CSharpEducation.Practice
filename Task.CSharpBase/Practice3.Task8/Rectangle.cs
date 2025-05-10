using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task8
{
    struct Rectangle
    {
        public double Height {  get; private set; }
        public double Width { get; private set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public double GetSquare()
        {
            return Width * Height;
        }
    }
}
