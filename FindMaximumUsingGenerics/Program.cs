using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Find Maximum Problem Using Generics.\n");

            Console.WriteLine("The Maximum Numbers are: ");

            int intMax = MaximumNumberCheck.MaxIntegerNumber(11, 33, 55);
            Console.WriteLine(intMax);

            double floatMax = MaximumNumberCheck.MaxFloatNumber(119.12, 33.34, 45.65);
            Console.WriteLine(floatMax);

            string stringMax = MaximumNumberCheck.MaxString("asad", "aakash", "adarsh");
            Console.WriteLine(stringMax);
        }
    }
}
