using System;
using System.Collections.Generic;
using System.Linq;
public class CyclicSort{

  private void Sort(int[] arr){
        int i =0;
  // Using while rather than for because we want to stay at 0 until the 0 is containing the correct element. We will continue to swap until 0 gets the correct value as soon as it gets the correct value we swap.
        while (i< arr.Length){
            // i th element shoul be at the right index.
          // Ex: in {3,5,2,1,4} 3 is at 0 index, if we look closely the correct arrangement should be {1,2,3,4,5}this means 3 should be at 2.
          // which is 3 -1. So 3 right position should be true.
          // If 3 is already present at 2 then dont swap, else swap.
            int rightIndex = arr[i]-1;
          // below if condition also handles the duplicate issue.
            if(arr[i] != arr[rightIndex] && rightIndex < arr.Length){
              swap(arr, i, rightIndex);
            }
            else{
                i++;
              }
          }
    }

  private void swap(int[] arr, int first, int second){
        int temp = 0;
        temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;          
    }

  public void caller(){
      int[] input = {3,5,2,1,4};
        Sort(input);
        for (int i=0; i< input.Length; i++){
            Console.WriteLine (input[i]);
          }
      }
}
