using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    class Triangle : Figure
    {
        readonly double side1;
        readonly double side2;
        readonly double side3;

        public override string Name { get; }
        public override double Area { get { return CalculateArea(); } }

        public Triangle(double side1, double side2, double side3, string name = "ABC")
        {
            Name = name;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            CheckIfSidesAreCorrect();
        }

        public Triangle(double cathetus1, double cathetus2, string name = "ABC")
        {
            Name = name;
            side1 = cathetus1;
            side2 = cathetus2;
            side3 = Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));

            CheckIfSidesAreCorrect();
        }

        public bool IsRight()
        {
            bool isSide1Hypotenuse = Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2);
            bool isSide2Hypotenuse = Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2);
            bool isSide3Hypotenuse = Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2);

            bool isTriangleRight = isSide1Hypotenuse || isSide2Hypotenuse || isSide3Hypotenuse;

            return isTriangleRight;
        }

        private double CalculateArea()
        {
            double halfPerimeter = (side1 + side2 + side3) / 2;

            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));

            return area;
        }



        private void CheckIfSidesAreCorrect()
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides of a triangle can't be less or equal to zero");
            }

            bool isSide1LessOtherSidesSum = side1 < side2 + side3;
            bool isSide2LessOtherSidesSum = side2 < side1 + side3;
            bool isSide3LessOtherSidesSum = side3 < side1 + side2;

            bool allSidesCorrect = isSide1LessOtherSidesSum && isSide2LessOtherSidesSum && isSide3LessOtherSidesSum;

            if (!allSidesCorrect)
            {
                throw new ArgumentException("Triangle with such sides can't exist");
            }
        }
    }
}
