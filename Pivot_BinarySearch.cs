using System;
//https://leetcode.com/problems/find-pivot-index/
public class Pivot_BinarySearch
{
    public void Caller()
    {
        int[] arr = { 1,7,3,6,5,6 };
        int s = 0;
        int e = arr.Length - 1;
        int mid = s + (e - s) / 2;
        while (s < e)
        {
            if (arr[mid] >= arr[0]){
                s = mid + 1;
            }
             else
            {
                e = mid;
            }
            mid = s + (e - s) / 2;
        }
        Console.WriteLine(arr[s]);
    }

}

