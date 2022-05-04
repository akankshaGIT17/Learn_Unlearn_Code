using System;
public class AlternateSwapInArray{
   public void Swapping(){
   int[] arr = new int[] {1,2,3,4,5};
   for(int i=0;i<arr.Length;i+=2){
     if(i+1<arr.Length){
     int temp = arr[i+1];
     arr[i+1]=arr[i];
     arr[i]=temp;
     }
     Console.WriteLine(arr[i]);
   }
  }
}