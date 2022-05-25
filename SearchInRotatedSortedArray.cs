using System;
using System.Collections.Generic;
using System.Linq;
public class SearchInRotatedSortedArray
{
    public int pivot(int[] arr)
    {
        int s = 0;
        int e = arr.Length - 1;
        int mid = s + (e - s) / 2;
        while (s < e)
        {
            if (arr[mid] >= arr[0])
            {
                s = mid + 1;
            }
            else
            {
                e = mid;
            }
            mid = s + (e - s) / 2;
        }
        return s;

    }
    public int BinarySearch(int[] arr, int n, int min, int max)
    {
        int mid = min + (max - min) / 2;
        while (min < max)
        {
            if (n == arr[mid])
                Console.WriteLine(mid);

            if (n < arr[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
            mid = min + (max - min) / 2;
        }
        return mid;
    }

    public int SearchElement(int[] arr, int key)
    {
        int p = pivot(arr);
        Console.WriteLine("Pivot = " + p + " Value = " + arr[p]);
        int print = 0;
        if (key >= arr[p] && key <= arr.Length - 1)
        {
            print = BinarySearch(arr, key, p+1, arr.Length - 1);
        }
        else
        {
            print = BinarySearch(arr, key, 0, p);
        }
        return print;

    }
    public void Caller()
    {
        Console.WriteLine("SearchInRotatedSortedArray");
        int[] arr = { 2 ,4 ,5 ,6 ,8 ,9 ,1};
        int find = 2;
        int result = SearchElement(arr, find);
        Console.Write(result);
    }
}