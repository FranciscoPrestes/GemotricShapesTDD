using System;
using GemotricShapesTDD.Domain.Entities;
using GemotricShapesTDD.Domain.Entities.TriangleTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GemotricShapesTDD.Test.Domain.Entities.TriangleTypes
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TheValuesOfSidesShouldBeBiggerThanZero()
        {
            new Triangle(-5, -5, -5);
        }

        [TestMethod]
        public void ItShoulCalculateTePerimeter()
        {
            var triangle = new Triangle(10,10,10);

            Assert.AreEqual(30, triangle.CalculatePerimeter());
        }

        [TestMethod]
        public void ItShouldBeClassifiedLikeEquilateral()
        {
            double side1 = 10;
            double side2 = 10;
            double side3 = 10;

            var triangle = new Triangle(side1, side2, side3).ClassifyBySides();

            Assert.AreEqual(side1, triangle.Side1);
            Assert.AreEqual(side2, triangle.Side2);
            Assert.AreEqual(side3, triangle.Side3);
            Assert.AreEqual(typeof(EquilateralTriangle), triangle.GetType());
        }

        [TestMethod]
        public void ItShouldBeClassifiedLikeIsosceles()
        {
            double side1 = 10;
            double side2 = 10;
            double side3 = 8;

            var triangle = new Triangle(side1, side2, side3).ClassifyBySides();

            Assert.AreEqual(side1, triangle.Side1);
            Assert.AreEqual(side2, triangle.Side2);
            Assert.AreEqual(side3, triangle.Side3);
            Assert.AreEqual(typeof(IsocelesTriangle), triangle.GetType());
        }


        [TestMethod]
        public void ItShouldBeClassifiedLikeScalene()
        {
            double side1 = 10;
            double side2 = 9;
            double side3 = 8;

            var triangle = new Triangle(side1, side2, side3).ClassifyBySides();

            Assert.AreEqual(side1, triangle.Side1);
            Assert.AreEqual(side2, triangle.Side2);
            Assert.AreEqual(side3, triangle.Side3);
            Assert.AreEqual(typeof(ScaleneTriangle), triangle.GetType());
        }

    }
}
