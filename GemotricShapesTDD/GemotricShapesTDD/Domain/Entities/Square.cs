using System;
using GemotricShapesTDD.Domain.Interfaces;

namespace GemotricShapesTDD.Domain.Entities
{
    public class Square : IShape
    {
        public readonly int NumberOfSizes = 4;
        public double Side { get; private set; }

        public Square(double side)
        {
            if (side <= 0)
            {
                throw new Exception("The side  should not be negative and less than zero.");
            }

            this.Side = side;
        }

        public double CalculateArea()
        {
            var power = 2;

            return Math.Pow(this.Side, power);
        }

        public double CalculatePerimeter()
        {
            return (this.Side * NumberOfSizes);
        }
    }
}
