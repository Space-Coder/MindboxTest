using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MindboxCSharp.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleTest_Square_Return458()
        {
            var circle = new Circle("Круг", 12.07);

            var expected = 458;

            Assert.AreEqual(expected, Math.Round(circle.Square()));
        }

    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleTest_Square_Return6()
        {
            var triangle = new Triangle("Треугольник", 3, 4, 5);

            var expected = 6;

            Assert.AreEqual(expected, triangle.Square());
        }


        public void IsStraight_Straight_ReturnTrue()
        {
            var triangle = new Triangle("Треугольник", 4, 5, 3);

            var expected = true;

            Assert.AreEqual(expected, triangle.IsStraight());
        }
    }

}
