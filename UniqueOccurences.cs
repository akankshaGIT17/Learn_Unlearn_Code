using System;
using System.Collections.Generic;
using System.Linq;

public class UnqueOccurences{
public List<int> find(int[] arr){
        
        List<int> arr2 = new List<int>();
        for(int i=0;i<arr.Length;i++){
            int count = 0;
            for (int j=i+1;j<arr.Length;j++){
                if(arr[i]== arr[j]){
                    arr2.Add(count++);
                }
            }
        }
        return arr2;
    }
  
  public void Caller(){
    int[] arr = {12, 12, 13, 13, 13, 14, 15, 15, 15, 15};
   var result =  find(arr);
    foreach (var t in result)
        {
            Console.WriteLine(t);
        }
  }
}