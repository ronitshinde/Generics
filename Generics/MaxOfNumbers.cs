﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxOfNumbers
    {
        public int MaxInteger(int numOne, int numTwo, int numThree)
        {
            if (numOne.CompareTo(numTwo) > 0 && numOne.CompareTo(numThree) > 0)
            {
                return numOne;
            }
            if (numTwo.CompareTo(numOne) > 0 && numTwo.CompareTo(numThree) > 0)
            {
                return numTwo;
            }
            if (numThree.CompareTo(numOne) > 0 && numThree.CompareTo(numTwo) > 0)
            {
                return numThree;
            }
            throw new Exception("numOne,numTwo,numThree are same");
        }
    }
}

