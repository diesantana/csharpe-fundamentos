namespace System
{
    internal static class StringExtensions
    {
        public static string Cut(this string thisValue, int quantity)
        {
            return thisValue.Substring(0, quantity) + "...";
        }
    }
}
