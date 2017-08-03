using System;
using GemotricShapesTDD.Domain.Interfaces;

namespace GemotricShapesTDD.Domain.Entities
{
    public class Triangle : IShape
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
