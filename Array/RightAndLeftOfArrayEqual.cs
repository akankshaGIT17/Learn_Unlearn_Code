/*
Find the uquilibrium element in the array such that left and right elements from that element have equal sum 
Ex : 11 22 33 22 11 100 99
O/p : 100
if we look all elements to the left of 100 they make a sum of 99 which is equal to the right of 100.
7 4 3 5 6
o/p = 3
as 7+4 = 11
5+6 = 11 and 3 is in mid of these 2 elements.

https://www.geeksforgeeks.org/find-element-array-sum-left-array-equal-sum-right-array/

Below solution is with 2 pointers.
*/
using System;
public class RightAndLeftOfArrayEqual{
  public void caller(){
    int[] arr = {1, 2, 3};
    int result = EquilibriumElement(arr, arr.Length);
    if(result != -1)
    Console.Write(arr[result]);
    else
    Console.Write("Not found");
  }

  public int EquilibriumElement (int[] arr, int size ){
    int start = 0;
    int end = size-1;
    int left_sum = 0;
    int right_sum=0;
    if(size==1)
    return arr[0];
    while(start <= size){
      if(start == end && left_sum == right_sum)
      return start;
      else if(start == end)
      return -1; // no such mid point found.
      if(left_sum < right_sum){
        left_sum += arr[start];
        start++;
        }
      else if(left_sum >= right_sum){
        right_sum += arr[end];
        end--;
      }
      
    }
    return -1;
  }
}
