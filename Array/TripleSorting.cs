using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Array
{
    class TripleSorting
    {
        public void GetSortedArray(int[] arr, int n)
        {
            int l = 0;
            int r = n-1;
            while (l < r)
            {
                if (arr[l] < arr[r])
                {
                    l++;
                }
                if (arr[l] > arr[r])
                {
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    r--; l++;

                    Console.WriteLine("left - " + l + "- right - " + r);

                }
                if (arr[l] == arr[r])
                {
                    r--;
                }
            }
            Print(arr);
        }
        public void Print(int[] arr)
        {
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        public void Caller()
        {
            int[] arr = { 0, 1, 2, 1, 2, 1, 2 };
            int n = arr.Length;
            GetSortedArray(arr, n);
        }
    }
}
