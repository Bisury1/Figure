using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFigure
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void InitializeImpossibleTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 21));
        }
    }
}
