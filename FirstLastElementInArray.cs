using System;
using System.Collections.Generic;
using System.Linq;
//https://www.codingninjas.com/codestudio/problems/first-and-last-position-of-an-element-in-sorted-array_1082549?source=youtube&campaign=love_babbar_codestudio2&utm_source=youtube&utm_medium=affiliate&utm_campaign=love_babbar_codestudio2
public class FirstLastElementInArray
{
    public int firstOcc(int[] arr, int size, int key)
    {
        int min = 0;
        int max = size-1;
        int mid = (max + min) / 2;
        int ans = -1;
        while (min <= max)
        {
            if (key == arr[mid])
            {
                ans = mid;
                max = mid - 1;
            }

            if (key < arr[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
            mid = (max + min) / 2;
        }
        return ans;

    }
    public int lastOcc(int[] arr, int size, int key)
    {
        int min = 0;
        int max = size-1;
        int mid = min + (max - min) / 2;
        int ans = -1;
        while (min <= max)
        {
            if (key == arr[mid])
            {
                ans = mid;
                min = mid + 1;
            }
            if (key < arr[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
            mid = min + (max - min) / 2;
        }
        return ans;

    }
public int totalOcc(int[] arr, int find){
    int[] ans = new int[5];
    ans[0] = firstOcc(arr, arr.Length, find);
    ans[1] = lastOcc(arr, arr.Length, find);
    int occ = ans[1]- ans[0] + 1;
    return occ;
}

    public void Caller()
    {
        Console.WriteLine("First Last Occurence");
        int[] arr = { 0 ,2 ,2 ,3  ,4 ,5,2 };
        int find = 2;
        Console.WriteLine(firstOcc(arr, arr.Length, find));
        Console.WriteLine(lastOcc(arr, arr.Length, find));
        Console.WriteLine("Occured" + totalOcc(arr, find));
    }
}