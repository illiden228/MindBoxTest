namespace MindBoxTest
{
    using System;

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = Math.Abs(radius);
        }

        public override double CalculateArea()
        {
            if (Area > -1) return Area;
            
            return Area = Math.PI * Radius * Radius;
        }
    }
}