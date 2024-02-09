namespace Course.Services
{
    internal class CalculateService
    {
        public static double Max(double x, double y)
        {
            return Math.Max(x, y);
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
    }
}
