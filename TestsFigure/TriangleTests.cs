using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Figure;

namespace TestsFigure
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void InitImpossibleTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 3.5));
        }
        [DataTestMethod]
        [DataRow(1, -1, -2)]
        [DataRow(2, 2, -4)]
        [DataRow(-3, 3, 6)]
        public void InitTriangleWithNegativeSide(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }
        [DataTestMethod]
        [DataRow(2, 1.5, 2.5)]
        [DataRow(2.5, 2, 1.5)]
        [DataRow(1.5, 2.5, 2)]
        public void GetSquareOfTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.IsNotNull(triangle);
            Assert.AreEqual(1.5, triangle.GetSquare());
        }
        [DataTestMethod]
        [DataRow(1, 4.8989794856, 5)]
        [DataRow(17, 8, 15)]
        public void InitRightTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.IsNotNull(triangle);
            Assert.IsTrue(triangle.IsRightTriangle);
        }
    }
}