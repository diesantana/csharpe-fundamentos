namespace AulaGenerics.Model.Services
{
    internal class PrintService<T>
    {
        public static void AddValue(List<T> list, T value)
        {
            list.Add(value);
        }

        public static T First(List<T> list)
        {
            return list[0];
        }

        public static void Print(List<T> list)
        {
            Console.Write("[" + list[0]);
            for (int i = 1; i < list.Count; i++)
            {
                Console.Write(", " + list[i]);
            }
            Console.WriteLine("]");
        }
    }
}
