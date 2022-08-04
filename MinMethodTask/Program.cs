using System;

namespace MinMethodTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 14, 16, 17, 19, 25, 2, 124, 154, 129 };
            Console.WriteLine(Min(array));
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i=1;i<array.Length;i++)
            {

                if (min > array[i])
                {
                    min = array[i];
                }
                
            }
            return min ;
        }
    }
}
