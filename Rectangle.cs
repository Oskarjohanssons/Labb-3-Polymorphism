using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double _length {  get; set; }
        public double _height { get; set; }
        public Rectangle()
        {
            _height = 5;
            _length = 6;
        }
        public void DisplayArea()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Arean på rektangel är: {Area()}");
        }
        
        public override double Area()
        {
            double area = _height * _length;
            return area;
        }
    }
}
