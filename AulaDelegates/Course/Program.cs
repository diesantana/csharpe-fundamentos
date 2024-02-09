using Course.Services;

namespace Course
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {

            BinaryNumericOperation op = CalculateService.Max;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculateService.Max);
            double a = 10;

            double b = 12;

            //double result = op.Invoke(a, b);
            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
