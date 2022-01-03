using System;


namespace Arrays
{
    class TwoDimensional
    {
        public static void MyArray()
        {
            int[,] arr = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int i, j;

            for (i = 0; i < 3; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, arr[i, j]);
                }
            }
        }
    }
}
