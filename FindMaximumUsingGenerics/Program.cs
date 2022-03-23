using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Find Maximum Problem Using Generics.\n");

            Console.WriteLine("The Maximum Numbers are: ");

            int intMax = MaxIntegerNumber(11, 33, 55);
            Console.WriteLine(intMax);

            double floatMax = MaxFloatNumber(119.12, 33.34, 45.65);
            Console.WriteLine(floatMax);
        }

        public static int MaxIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;

            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;

            return thirdValue;
        }

        public static double MaxFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;

            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;

            return thirdValue;
        }
    }
}
