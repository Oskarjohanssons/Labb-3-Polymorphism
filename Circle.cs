using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Circle : Geometry
    {
        public double _radius {  get; set; }
        public Circle() 
        {
            _radius = 3;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Arean på cirkeln är: {Area()}");
        }
        public override double Area()
        {
            double area = _radius * _radius * PI;
            return area;
        }
    }
}
