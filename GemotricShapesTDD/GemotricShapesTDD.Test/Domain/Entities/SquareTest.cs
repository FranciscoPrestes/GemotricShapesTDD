using System;
using System.Linq.Expressions;
using GemotricShapesTDD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GemotricShapesTDD.Test.Domain.Entities
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ItShouldNotRecbeNegativeAndLessThanZeroValuesOnContructor()
        {
            new Square(-5);
        }

        [TestMethod]
        public void ItShouldCalculateArea()
        {
            var square = new Square(5);

            Assert.AreEqual(25, square.CalculateArea());
        }

        [TestMethod]
        public void ItShouldCalculatePerimeter()
        {
            var square = new Square(5);

            Assert.AreEqual(20, square.CalculatePerimeter());
        }
    }
}
