using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Find Maximum Problem Using Generics.\n");

            Console.WriteLine("The Maximum Number is: ");

            int output = MaximumNumberCheck.MaxIntegerNumber(11, 33, 55);
            Console.WriteLine(output);
        }
    }
}
