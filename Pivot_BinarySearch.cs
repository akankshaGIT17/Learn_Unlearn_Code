using System;
public class Pivot_BinarySearch
{
    public void Caller()
    {
        int[] arr = { 17, 21, 23, 26, 13, 15 };
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

