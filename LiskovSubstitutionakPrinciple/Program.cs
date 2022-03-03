using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionakPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle shape; 

            shape = new Rectangle(1, 2);
            Console.WriteLine(shape.GetArea());

            shape = new Square(1);
            Console.WriteLine(shape.GetArea());

            Console.ReadLine();
        }
    }

    public class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }
    }

    public class Rectangle
    {
        private int _height { get; set; }
        private int _width { get; set; }

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public virtual int GetArea()
        {
            return _height * _width;
        }
    }
}
