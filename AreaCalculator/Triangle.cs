using System.Reflection.Metadata;

namespace AreaCalculator
{
    public class Triangle : Figure
    {
        private int side1;
        private int side2;
        private int side3;

        public int Side1
        {
            get => side1;

            set
            {
                if(value >= 0)
                    side1 = value;
                else
                    throw new ArgumentException("Cannot be negative", nameof(value));
            }
        }

        public int Side2
        {
            get => side2;

            set
            {
                if (value >= 0)
                    side2 = value;
                else
                    throw new ArgumentException("Cannot be negative", nameof(value));
            }
        }

        public int Side3
        {
            get => side3;

            set
            {
                if (value >= 0)
                    side3 = value;
                else
                    throw new ArgumentException("Cannot be negative", nameof(value));
            }
        }

        public Triangle() { }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3)/2;

            return Math.Sqrt(
                       semiPerimeter
                    * (semiPerimeter - Side1)
                    * (semiPerimeter - Side2)
                    * (semiPerimeter - Side3)
                );
        }

        public bool IsRightTriangle()
        {
            bool res;

            if (Side1 > Side2 && Side1 > Side3)
                res = (Side1*Side1) == (Side2*Side2) + (Side3*Side3);
            else if (Side2 > Side1 && Side2 > Side3)
                res = (Side2 * Side2) == (Side1 * Side1) + (Side3 * Side3);
            else 
                res = (Side3 * Side3) == (Side1 * Side1) + (Side2 * Side2);

            return res;
        }
    }
}
