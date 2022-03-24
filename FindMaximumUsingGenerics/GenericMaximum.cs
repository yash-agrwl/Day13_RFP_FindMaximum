using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class GenericMaximum<T> where T : IComparable
    {

        public T[] Values;

        public GenericMaximum(T[] value)
        {
            this.Values = value;
        }

        public static T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }

        public static T MaxValue(T[] value)
        {
            var sortedArray = Sort(value);
            return sortedArray[^1];
        }

        public T MaxValue()
        {
            var max = MaxValue(this.Values);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.Values);
            Console.WriteLine(max);
        }
    }
}
