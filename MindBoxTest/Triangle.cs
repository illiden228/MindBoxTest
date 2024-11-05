namespace MindBoxTest
{
    using System;

    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Треугольник с такими стороннами существовать не может!");
        
            SideA = Math.Abs(sideA);
            SideB = Math.Abs(sideB);
            SideC = Math.Abs(sideC);
        }
        
        public override double CalculateArea()
        {
            if (Area > -1) return Area;
            
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }
}