﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class MaximumNumberCheck
    {
        public static int MaxIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if( firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >=0 )
                return firstValue;

            if( secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0 )
                return secondValue;

            return thirdValue;
        }
    }
}
