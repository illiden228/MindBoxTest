namespace MindBoxTestXUnit
{
    using MindBoxTest;
    using Xunit;

    public class AreaTests
    {
        [Theory]
        [InlineData( 5, 78.5398)]
        public void CircleArea(double radius, double expected)
        {
            var circle = new Circle(radius);
            double area = circle.CalculateArea();
            Assert.Equal(expected, area, 4);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        public void TriangleArea(double sideA, double sideB, double sideC, double expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            double area = triangle.CalculateArea();
            Assert.Equal(expected, area, 4);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void TriangleIsRight(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.True(triangle.IsRightTriangle());
        }

        [Theory]
        [InlineData(3, 4, 6)]
        public void TriangleIsNonRight(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.False(triangle.IsRightTriangle());
        }
    }
}