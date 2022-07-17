using System;

namespace CSharpInDepth
{
    static class Program
    {

        static void Main()
        {
            var numbers = GetNumbers();
            var firstTwoNumbers = CopyAtMost<int>(numbers, 2);
            Console.WriteLine(firstTwoNumbers.Count);

            var names = GetNames();
            var fisrtTwoNames = CopyAtMost<string>(names, 2);
            Console.WriteLine(fisrtTwoNames.Count);

        }


        private static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            return input.Take(maxElements).ToList();
        }

        private static List<int> GetNumbers()
        {
            return new List<int>() { 1, 2, 3123, 123, 123, 123, 123, 123 };
        }

        private static List<string> GetNames()
        {
            return new List<string>() { "name1", "name2", "name3", "name4", "name5", "name6"};
        }
    }

}