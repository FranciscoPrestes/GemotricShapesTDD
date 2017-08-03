using System;
using GemotricShapesTDD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GemotricShapesTDD.Test.Domain.Entities
{
    [TestClass]
   public class RectangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ItShouldNotReceiveNegativeAndLessThanZeroValuesOnConstructor()
        {
            new Rectangle(-5, -10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ItShouldNotReceiveNegativeAndLessThanZeroValuesToBaseOnConstructor()
        {
            new Rectangle(-5, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ItShouldNotReceiveNegativeAndLessThanZeroValuesToHeigthOnConstructor()
        {
            new Rectangle(5, -10);
        }

        [TestMethod]
        public void ItShouldCalculateArea()
        {
            var rectangle = new Rectangle(5, 10);

            //base * heigth
            Assert.AreEqual(50,rectangle.CalculateArea());
        }

        [TestMethod]
        public void ItShouldCalculatePerimeter()
        {
            var rectangle = new Rectangle(5,10);

            //2 * (base + heigth)  
            Assert.AreEqual(30,rectangle.CalculatePerimeter());
        }
    }
}
