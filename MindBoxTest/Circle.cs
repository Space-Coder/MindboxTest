using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Circle : ShapeBase
    {
        private double Radius { get; set; }
        public Circle(string shapeName, double radius) : base(shapeName)
        {
            Radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
