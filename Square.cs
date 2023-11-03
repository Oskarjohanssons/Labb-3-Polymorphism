using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Square : Geometry
    {
        public double _side {get; set;}
        public Square() 
        {
            _side = 8;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Arean på fyrkanten är: {Area()}");
        }
        public override double Area()
        {
            double area = _side * _side;
            return area;
        }
    }
}
