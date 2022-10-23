using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxCSharp
{
    public class Triangle : ShapeBase
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(string shapeName, double a, double b, double c) : base(shapeName)
        {
            if (IsExist(a, b, c))
            {
                A = a;
                B = b;
                C = c;
            }
            if (IsStraight())
            {
                Debug.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Debug.WriteLine("Треугольник не прямоугольный");
            }

        }

        public double Square()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private bool IsExist(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Такого треугольника не существует. Одна или несколько сторон меньше 0");
            }
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new Exception("Такого треугольника не существует. Одна из сторон больше суммы двух других сторон");
            }

            return true;
        }

        public bool IsStraight()
        {
            if ((Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)) || (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(A, 2) == Math.Pow(C, 2) + Math.Pow(B, 2)))
            {
                return true;
            }
            return false;
        }
    }
}
