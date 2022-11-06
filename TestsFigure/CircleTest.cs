using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Figure;

namespace TestsFigure
{
    [TestClass]
    public class CircleTest
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-22)]
        [DataRow(-3)]
        public void InitImpossibleCircle(int radius)
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }
        [TestMethod]
        public void GetSquareSingleCircle()
        {
            var circle = new Circle(1);
            Assert.AreEqual(Math.PI, circle.GetSquare());
        }
        [TestMethod]
        public void GetSquareCircle()
        {
            var circle = new Circle(4);
            Assert.AreEqual(Math.PI * 16, circle.GetSquare());
        }
    }
}
