using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9SecondHighestNumberIntArray
{
    class FindSecondHighestInt
    {
        int[] intArray;

        public FindSecondHighestInt(string[] p)
        {
            intArray = new int[p.Length];
            for (int i = 0; i < p.Length; i++) {
                intArray[i] = Convert.ToInt32(p[i]);
            }
        }

        public string findIt()
        {
            int highest=0, secondHighest=0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > highest)
                {
                    highest = intArray[i];
                }
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > secondHighest&& intArray[i] != highest)
                {
                    secondHighest = intArray[i];
                }
            }
            return secondHighest.ToString();
        }
    }
}
