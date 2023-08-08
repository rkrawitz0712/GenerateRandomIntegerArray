using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateRandomIntegerArray
{
    class GenerateRandomIntegerArraySizeN
    {
        private int[] theArray;
        private int maxValue;

        public GenerateRandomIntegerArraySizeN() { }

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
                theArray[n] = rnd.Next() % maxValue;

            return theArray;
        }
    }
}
