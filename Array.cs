using System;

namespace Arrays
{
    class Array
    {
        public static void MyArray()
        {
            int[] numbers = { 13, 28, 35, 32, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
    }
}
