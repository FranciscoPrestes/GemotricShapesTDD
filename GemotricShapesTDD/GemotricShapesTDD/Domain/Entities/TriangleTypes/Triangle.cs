using System;
using System.Collections.Generic;
using System.Linq;
using GemotricShapesTDD.Domain.Interfaces;

namespace GemotricShapesTDD.Domain.Entities.TriangleTypes
{
    public class Triangle : IShape
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new Exception("The values of sides should be bigger than zero");
            }

            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }
        public double CalculateArea()
        {
          throw new NotImplementedException("Not implemented. All types of triangle has your self way to calculate area.");
        }

        public double CalculatePerimeter()
        {
            return (this.Side1 + this.Side2 + this.Side3);
        }

        public Triangle ClassifyBySides()
        {

            var tianglesTable = new Dictionary<int, Triangle>()
            {
                {0, new ScaleneTriangle(this.Side1, this.Side2, this.Side3)},
                {1, new IsocelesTriangle(this.Side1, this.Side2, this.Side3)},
                {3, new EquilateralTriangle(this.Side1, this.Side2, this.Side3)},
             };


            return tianglesTable[NumberOfEqualsSides()];

            
        }


        private int NumberOfEqualsSides()
        {
            var equalSides = new[]
            {
                Side1.Equals(Side2),
                Side1.Equals(Side3),
                Side2.Equals(Side3)
            };

            return equalSides.Count(e => e);

        }


    }
}
