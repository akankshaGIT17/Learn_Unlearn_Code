/******************************************************************************

                           Find Number in a infinit sorted array.
                Array does not have any duplicate values.
https://www.geeksforgeeks.org/find-position-element-sorted-array-infinite-numbers/

*******************************************************************************/

using System;
class FindNumberInInfinitSortedArray {
  void Caller() {
       int[] arr = {3, 5, 7, 9, 10, 90, 100, 130,
                               140, 160, 170};
        var element = searchNumberInInfiniteRange(arr,90);
        
    Console.WriteLine("Found at position : "+element);
  }
  int searchNumberInInfiniteRange(int[] a, int t){
      int s=0;
      int e= 1;
      while(t > a[e])
     {
          int temp= e+1;
          e= e+(e-s+1) * 2;
          s= temp;
     }
     return BinarySearch(a,t,s,e);
      
  }
 int BinarySearch(int[] arr, int t, int s, int e)
  {
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
        if(t== arr[mid]){
        return mid;
        }
        else{
            return -1;
        }
    }
      
  }

