using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array1 = new int[5];

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            // array2 = new int[] { 11, 33, 55, 77, 99 }; Sobescrever um array

            foreach (int i in array2)
            {
                Console.WriteLine(i + "");
            }

            Console.ReadKey();

            int[] array3 = { 1, 2, 3, 4, 5, 6 }; // outra forma de declarar um array

            foreach (int i in array3)
            {
                Console.WriteLine(i + "");
            }

            Console.ReadKey();

            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int i in multiDimensionalArray2)
            {
                Console.WriteLine(i + "");
            }
            Console.ReadKey();

            int[][] jaggedArray = new int[6][];

            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 1, 2 };

            foreach (int [] row in jaggedArray)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }            

        }
    }
}
