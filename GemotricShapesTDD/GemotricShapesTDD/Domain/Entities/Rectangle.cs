using System;
using System.Linq.Expressions;
using GemotricShapesTDD.Domain.Interfaces;

namespace GemotricShapesTDD.Domain.Entities
{
    public class Rectangle : IShape
    {
        public double Base { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double baseValue, double heigthtValue)
        {
            if (baseValue <= 0 || heigthtValue <= 0)
            {
                throw new Exception("It should not recive negative values or values less than zero.");
            }

            this.Base = baseValue;
            this.Height = heigthtValue;
        }
        public double CalculateArea()
        {
            return this.Base * this.Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (this.Base + this.Height);
        }
    }
}
