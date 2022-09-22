using System;

namespace GeometryLibrary
{
    class Circle : Figure
    {
        readonly double radius;

        public override string Name { get; }
        public override double Area { get { return CalculateArea(); } }

        public Circle(double radius, string name = "Unnamed circle")
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius can't be less or equal to zero");
            }

            this.radius = radius;
            Name = name;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
