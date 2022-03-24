using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Find Maximum Problem Using Generics.\n");

            Console.WriteLine("The Maximum Numbers are: ");

            int[] intArr = { 11, 33, 55, 99 };
            int intMax = new GenericMaximum<int>(intArr).MaxValue();
            Console.WriteLine(intMax);

            double[] doubleArr = { 119.12, 33.34, 45.65, 77.76 };
            double floatMax = new GenericMaximum<double>(doubleArr).MaxValue();
            Console.WriteLine(floatMax);

            string[] stringArr = { "asad", "aakash", "adarsh", "aram" };
            string stringMax = new GenericMaximum<string>(stringArr).MaxValue();
            Console.WriteLine(stringMax);
        }
    }
}
