using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Find Maximum Problem Using Generics.\n");

            Console.WriteLine("The Maximum Numbers are: ");

            int intMax = MaxValue<int>(11, 33, 55);
            Console.WriteLine(intMax);

            double floatMax = MaxValue<double>(119.12, 33.34, 45.65);
            Console.WriteLine(floatMax);

            string stringMax = MaxValue<string>("asad", "aakash", "adarsh");
            Console.WriteLine(stringMax);
        }

        public static T MaxValue<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;

            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;

            return thirdValue;
        }
    }
}
