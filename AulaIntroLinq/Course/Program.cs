namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Specify the data source
            int[] numbers = { 2, 3, 4, 5};

            // Define the query expression
            IEnumerable<int> result = numbers
                .Where(num => num % 2 == 0)
                .Select(num => num * 10);
            
            // Execute the query
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

        }
    }
}
