using System;
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
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            return (this.Side1 + this.Side2 + this.Side3);
        }

        public Triangle ClassifyBySides()
        {
            switch (NumberOfEqualsSides())
            {
                case 0: // All sides are note equals.
                    {
                        return new ScaleneTriangle(this.Side1, this.Side2, this.Side3);
                    }
                case 1:// One equality represents two equals sides.
                    {
                        return new IsocelesTriangle(this.Side1, this.Side2, this.Side3);
                    }
                case 3: // all sides are equals.
                    {
                        return new EquilateralTriangle(this.Side1, this.Side2, this.Side3);
                    }

                default: // Returns the base triangle. Never gonna happen!
                    {
                        return this;
                    }
            }
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
