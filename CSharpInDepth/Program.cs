using System;
using System.Globalization;

namespace CSharpInDepth
{
    static class Program
    {

        static void Main()
        {
            Item<string>.Increment();
            Item<string>.Increment();
            Item<string>.Increment();
            Item<string>.Increment();
            Item<string>.Display();

            Item<int>.Increment();
            Item<int>.Display();
        }


    }

    public static class Item<T>
    {
        private static int value;

        static Item()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }
}