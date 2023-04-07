using System;
using System.Collections.Generic;
using System.Linq;
public class MissingNumber{
/* 
  https://leetcode.com/problems/missing-number/description/
  */
   private int Sort(int[] arr){
        int i =0;
          while (i< arr.Length){
          // Here it is mentioned in the question that every entry will have the value same as their index as they are considering the range from [0,n] thats why we are taking that same number and not subtracting.
            int rightIndex = arr[i];
            if(rightIndex < arr.Length && arr[i] != arr[rightIndex]){
              swap(arr, i, rightIndex);
            }
            else{
           
            i++;
          }
            }
     for(int j =0; j< arr.Length; j++){
        // {4,0,2,1} after running the entire sort function the output will be {0,1,2,4}. 4 is the value which is not same to its index. ie 3 thus 3 is the missing number and we will return that index value.
       if(j != arr[j])
       return j;
     }
     // If array is already sorted lets say {0,1} then the missing number is the next number, here it is 2.
     return arr.Length;
    }

  private void swap(int[] arr, int first, int second){
        int temp = 0;
        temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;          
    }

public void findNumber(int[] arr){
  int num = Sort(arr);
  Console.WriteLine(num);
  
}
 public void caller(){
   int[] input = //{1,2}; - 0
   {4,0,2,1} ;//{0,2,3,1,7,5,6,9,8,10,11};//{0,1} - 2;
   //{9,6,4,2,3,5,7,0,1}-8;
   //{3,0,1}; - 2
   
   findNumber(input);
  }
}
