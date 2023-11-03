using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Geometry
    {
        public double PI = Math.PI;
        public Geometry()
        {
        }
        public virtual double Area()
        {
            return 0;
        }
    }
}
