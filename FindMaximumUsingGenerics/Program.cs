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
            new GenericMaximum<int>(intArr).PrintMaxValue();

            double[] doubleArr = { 119.12, 33.34, 45.65, 77.76 };
            new GenericMaximum<double>(doubleArr).PrintMaxValue();

            string[] stringArr = { "asad", "aakash", "adarsh", "aram" };
            new GenericMaximum<string>(stringArr).PrintMaxValue();
        }
    }
}
