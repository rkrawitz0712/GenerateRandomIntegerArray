using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateRandomIntegerArray
{
    class CreateRandomArrays
    {
        public CreateRandomArrays()
        {
            int arraySize;
            int[] anArray;
            int[] anOtherArray;
            GenerateRandomIntegerArraySizeN generateAnArray = new GenerateRandomIntegerArraySizeN();
            GenerateRandomIntegerArraySizeNWithNoDups generateAnOtherArray = new GenerateRandomIntegerArraySizeNWithNoDups();

            arraySize = 5;
            anArray = generateAnArray.createArray(arraySize);
            anOtherArray = generateAnOtherArray.createArray(arraySize);
            Console.WriteLine("array of " + arraySize + " allowing dups");
            for (int n = 0; n < anArray.Length; n++)
                Console.Write(anArray[n] + "  ");
            Console.WriteLine("\narray of " + arraySize + " with no dups");
            for (int n = 0; n < anOtherArray.Length; n++)
                Console.Write(anOtherArray[n] + "  ");

            Console.WriteLine("\n");

            arraySize *= 2;
            anArray = generateAnArray.createArray(arraySize);
            anOtherArray = generateAnOtherArray.createArray(arraySize);
            Console.WriteLine("array of " + arraySize + " allowing dups");
            for (int n = 0; n < anArray.Length; n++)
                Console.Write(anArray[n] + "  ");
            Console.WriteLine("\narray of " + arraySize + " with no dups");
            for (int n = 0; n < anOtherArray.Length; n++)
                Console.Write(anOtherArray[n] + "  ");

            Console.WriteLine("\n");

            arraySize *= 2;
            anArray = generateAnArray.createArray(arraySize);
            anOtherArray = generateAnOtherArray.createArray(arraySize);
            Console.WriteLine("array of " + arraySize + " allowing dups");
            for (int n = 0; n < anArray.Length; n++)
                Console.Write(anArray[n] + "  ");
            Console.WriteLine("\narray of " + arraySize + " with no dups");
            for (int n = 0; n < anOtherArray.Length; n++)
                Console.Write(anOtherArray[n] + "  ");

            Console.WriteLine();

            arraySize = 10000;
            anOtherArray = generateAnOtherArray.createArray(arraySize);
            Console.WriteLine("\narray of " + arraySize + " with no dups");
            for (int n = 0; n < anOtherArray.Length; n++)
            {
                Console.Write(anOtherArray[n] + "  ");
                if (n % 10 == 0 && n != 0)
                    Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

