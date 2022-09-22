using System;

namespace GeometryLibrary
{
    public static class AreaCalculator
    {
        public static double Circle(double radius)
        {
            Circle circle = new Circle(radius);

            return circle.Area;
        }

        public static double Triangle(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);

            return triangle.Area;
        }

        public static double Triangle(double cathetus1, double cathetus2)
        {
            Triangle triangle = new Triangle(cathetus1, cathetus2);

            return triangle.Area;
        }        
        
        public static bool IsTriangleRight(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);

            return triangle.IsRight();
        }

        /// <summary>
        /// One parameter considered as a radius, two as catheti, three as sides of a triangle
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static double Area(params double[] parameters)
        {
            double area;

            switch (parameters.Length)
            {
                case 1:
                    area = Circle(parameters[0]);
                    break;
                case 2:
                    area = Triangle(parameters[0], parameters[1]);
                    break;
                case 3:
                    area = Triangle(parameters[0], parameters[1], parameters[2]);
                    break;
                default:
                    throw new ArgumentException("Wrong number of parameters. From 1 to 3 parameters can be accepted");
            }

            return area;
        }
    }
}
