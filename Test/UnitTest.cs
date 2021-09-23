using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;
using static System.Math;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Circle c = new Circle(5);
            Assert.AreEqual(Math.PI * Pow(5, 2), c.getSquare());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Triangle t = new Triangle(3,4,5);
            Assert.AreEqual(6, t.getSquare());
        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
        "Value must be positive.")]
        public void TestMethod3()
        {
            Triangle t = new Triangle(-2,-3,-4);           
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
        "Value must be positive.")]
        public void TestMethod4()
        {
            Circle c = new Circle(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
        "Triangle doesn't exist.")]
        public void TestMethod5()
        {
            Triangle t = new Triangle(2, 3, 10);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.AreEqual(true, t.checkReck());
        }
    }
}
