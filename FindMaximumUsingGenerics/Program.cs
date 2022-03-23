using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Find Maximum Problem Using Generics.\n");

            Console.WriteLine("The Maximum Numbers are: ");

            int intMax = new GenericMaximum<int>(11, 33, 55).MaxValue();
            Console.WriteLine(intMax);

            double floatMax = new GenericMaximum<double>(119.12, 33.34, 45.65).MaxValue();
            Console.WriteLine(floatMax);

            string stringMax = new GenericMaximum<string>("asad", "aakash", "adarsh").MaxValue();
            Console.WriteLine(stringMax);
        }
    }
}
