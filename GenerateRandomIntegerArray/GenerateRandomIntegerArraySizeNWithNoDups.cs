using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateRandomIntegerArray
{
    class GenerateRandomIntegerArraySizeNWithNoDups
    {
        private int[] theArray;
        private int maxValue;

        public GenerateRandomIntegerArraySizeNWithNoDups() { }

        public int[] createArray(int arraySize)
        {
            maxValue = arraySize * 10000;

            if (arraySize > 0)
                theArray = new int[arraySize];
            else
                return null;

            return generateArray();
        }

        private int[] generateArray()
        {
            Random rnd = new Random();

            for (int n = 0; n < theArray.Length; n++)
            {
                int temp = rnd.Next() % maxValue;

                if (isNotADup(temp, n))
                    theArray[n] = temp;
                else
                    n--;
            }

            return theArray;
        }

        private bool isNotADup(int temp, int n)
        {
            for(int p = 0; p < n; p++)
            {
                if (temp == theArray[p])
                    return false;
            }

            return true;
        }
    }
}

