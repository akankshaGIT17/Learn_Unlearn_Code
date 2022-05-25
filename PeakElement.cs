using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/peak-index-in-a-mountain-array/
public class PeakElement{
public int hieghestElement(int[] arr){
  int s= 0;
  int e= arr.Length-1;
  int mid = s+(e-s)/2;
  while(s<e){
    if(arr[mid] < arr[mid+1]){
      s = mid+1;
    }
    else{
      e = mid;
    }
    mid = s+(e-s)/2;
  }
  return s;
}
 public void Caller(){
   int[] arr = {3,4,5,1};
var result = hieghestElement(arr);
    Console.WriteLine(arr[result] + " - index - " + result);
  } 
}