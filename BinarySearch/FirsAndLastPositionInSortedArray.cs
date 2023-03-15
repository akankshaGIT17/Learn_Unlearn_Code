/******************************************************************************

                          First and Last Element occurence in a sorted array
                          Using Binary Search

*******************************************************************************/

using System;
class FirsAndLastPositionInSortedArray {
  void Caller() {
       int[] arr = {3, 5, 7, 9, 9, 90, 100, 130,
                               140, 160, 170};
        var element = firstLastElement(arr,9);//[3,4]
        
    Console.WriteLine("First Found at position : "+element[0]);
    Console.WriteLine("Second Found at position : "+element[1]);
  }
  int[] firstLastElement(int[] a, int t){
     int[] ans = {-1,-1};
     ans[0] = BinarySearch(a,t,true);
     ans[1] = BinarySearch(a,t,false);
     return ans;
      
  }
 int BinarySearch(int[] arr, int t, bool findFirst)
  {
      int s =0;
      int e = arr.Length;
     int ans=-1;
      
        while (s <= e)
        {
            int mid = s + (e-s) / 2;
           if (t < arr[mid])
            {
                e = mid - 1;
            }
            else if(t > arr[mid])
            {
                s = mid + 1;
            }
            else{
            ans = mid;
                if(findFirst)
                     e = mid-1;
                 else
                     s=mid+1;
           
            }
        }
        return ans;
       
    }
      
  }

