using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class GenericMaximum<T> where T : IComparable
    {

        public T FirstValue, SecondValue, ThirdValue;

        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.ThirdValue = thirdValue;
        }

        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;

            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;

            return thirdValue;
        }

        public T MaxValue()
        {
            T max = GenericMaximum<T>.MaxValue(this.FirstValue, this.SecondValue, this.ThirdValue);
            return max;
        }
    }
}
