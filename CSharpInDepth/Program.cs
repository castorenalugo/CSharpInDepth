using System;
using System.Globalization;

namespace CSharpInDepth
{
    static class Program
    {

        static void Main()
        {
            var numbers = GetNumbers();
            PrintItems(numbers);

        }

        static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }

        private static List<int> GetNumbers()
        {
            return new List<int>() { 1, 2, 3123, 123, 123, 123, 123, 123 };
        }

    }
}