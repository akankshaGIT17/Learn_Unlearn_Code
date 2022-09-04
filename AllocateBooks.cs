using System;
using System.Linq;

namespace main
{
    //Coding ninjas : Allocate Books
    public class AllocateBooks
    {
        bool isPossible(int[]arr, int mid, int days)
        {
            int count = 0;
            int sum = 0;
            for(int i=0;i<arr.Length; i++)
            {
                if (sum + arr[i] < mid)
                {
                    sum = sum + arr[i];
                }
                else
                {
                    count++;
                    if(count > days || arr[i] > mid)
                    {
                        return false;
                    }
                    sum = arr[i];
                }
            }
            return true;
        }
        public int AllocatingBooks(int[] arr, int days, int chap)
        {
            int sum = arr.Sum(t => t);
            int start = 0;
            int end = chap;
            int ans = -1;
            int mid = start + (end-start) / 2;
            while (start < end)
            {
                if(isPossible(arr, mid, days))
                {
                    ans = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                mid = start + mid / 2;
            }
            return ans;

        }
        public void Caller() { 
        
        int[] arr = { 1, 2, 2, 3, 1 };
            int days = 3;
            int chap = 5;
            Console.WriteLine(AllocatingBooks(arr, days, chap));
        }
    }

    
}
