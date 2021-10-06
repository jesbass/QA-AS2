using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_AS2
{
    public class Rectangle
    {
        private int Lenght { get; set; }
        private int Width { get; set; }
        public Rectangle()
        {
            Lenght = 1;
            Width = 1;
        }
        public Rectangle(int lenght, int width)
        {
            Lenght = lenght;
            Width = width;
        }
        public int GetLength()
        {
            return Lenght;
        }
        public int SetLength(int length)
        {
            Lenght = length;
            return Lenght;
        }
        public int GetWidth()
        {
            return Width;
        }
        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }
        public int GetPerimeter()
        {
            return (Lenght * 2) + (Width * 2);
        }
        public int GetArea()
        {
            return Lenght * Width;
        }
    }
}
