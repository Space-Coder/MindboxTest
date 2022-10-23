using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Triangle : ShapeBase
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(string shapeName, double a, double b, double c) : base(shapeName)
        {
            if (isExist(a,b,c))
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public double Square()
        {
            return Math.Sqrt(A * A + B * B);
        }

        private bool isExist(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Такого треугольника не существует. Одна или несколько сторон меньше 0");
            }
            if (a > (b+c) || b > (a+c) || c> (a+b))
            {
                throw new Exception("Такого треугольника не существует. Одна из сторон больше суммы двух других сторон");
            }

            return true;
        }
    }
}
