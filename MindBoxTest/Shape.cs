namespace MindBoxTest
{
    public abstract class Shape : IArea
    {
        protected double Area = -1;

        public abstract double CalculateArea();
    }
}