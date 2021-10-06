using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_AS2
{
    public class Rectangle
    {
        private int Length { get; set; }
        private int Width { get; set; }
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int GetLength()
        {
            return Length;
        }
        public int SetLength(int length)
        {
            Length = length;
            return Length;
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
            return (Length * 2) + (Width * 2);
        }
        public int GetArea()
        {
            return Length * Width;
        }
    }
}
