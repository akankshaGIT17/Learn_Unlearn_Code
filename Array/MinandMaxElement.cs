//https://www.geeksforgeeks.org/maximum-and-minimum-in-an-array/
using System;

namespace main.Array
{
    public class MinandMaxElement
    {
        public bool PRINT(int[] a)
        {
            // Output {5,4,3,2,1};
            int min = a[0];
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }

            }
            Console.WriteLine("MAx is " + max);
            Console.WriteLine("Min is " + min);
            return true;

        }
        public void Caller()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("- " + PRINT(a));
        }
    }
}
