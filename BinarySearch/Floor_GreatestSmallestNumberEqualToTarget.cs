/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class GreatestSmallestNumberEqualToTarget {
  void Caller() {
   
   int[] a = { 16, 17,  19, 20, 21, 22, 23, 24 };
    int n = 18;
    // output should be 17 as it is the maximum smallest number
   int nearestElement = greaterThenaOrEqual(a,n);
   Console.WriteLine(nearestElement);
  }
  int greaterThenaOrEqual(int[] arr, int t)
  {
     
        int s = 0;
        int e = arr.Length-1;
        int mid = s + (e-s) / 2;
        while (e > s)
        {
           if (t < arr[mid])
            {
                e = mid - 1;
            }
            else
            {
                s = mid + 1;
            }
            mid = s + (e-s) / 2;
        }
        return arr[e];
      
  }
  }

