using System;
public class BinarySearch
{
    public void search()
    {
        int[] a = { 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        int n = 18;
        int min = 0;
        int max = a.Length;
        int mid = min + (max - min) / 2;
        while (min < max)
        {
            if (n == a[mid])
                Console.WriteLine(mid);

            if (n < a[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
            mid = min + (max - min) / 2;
        }
        Console.WriteLine("Ended");
    }
}