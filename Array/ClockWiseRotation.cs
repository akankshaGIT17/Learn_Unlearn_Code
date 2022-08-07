//https://practice.geeksforgeeks.org/problems/cyclically-rotate-an-array-by-one2614/1?page=1&curated[]=2&sortBy=submissions
using System;

public class ClockWiseRotation
{
    public bool PRINT(int[] a)
    {
        // Output {5,4,3,2,1};
        var arrLength = a.Length;
        int temp = a[arrLength - 1];
        for (int i = arrLength - 1; i >= 1; i--)
        {
            a[i] = a[i - 1];
        }
        a[0] = temp;
        Console.WriteLine("ClockWise shift");
        for (int i = 0; i <= arrLength - 1; i++)
        {
            Console.WriteLine("" + a[i]);
        }

        return true;

    }
    public void Caller()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Console.WriteLine("- " + PRINT(a));
    }
}