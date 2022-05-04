using System;
using System.Collections.Generic;
using System.Linq;
public class PrimeNumbers{
  public int search (){
 int[] a= {16,17,2, 3, 5, 7, 11, 13, 17, 19, 23,18,19,20,21,22,23,24};
    List<int> output = new List<int>();
    int halfSize=0;
    for(var i=0; i< a.Length; i++){
  if(a[i] > 1){
    int k=2;
    halfSize=a[i]/2;
int z=0;
    while(k < halfSize){
     z  = a[i]%k;
     if(z==0){
         break;
     }
      k++;
    }
    if(z!=0){
        output.Add(a[i]);
      }
  }
  }
    foreach(var t in output){
      Console.WriteLine(t);
    }
    return 0;
  }
  public void Sieve_of_Eratosthenes(){
     int size = 10;
       bool[] arr = new bool[size+1];
      arr =  Enumerable.Repeat(true, size+1).ToArray();
  
    arr[0]=false;
    arr[1] = false;
    for(int i=2; i<size; i++){
      for(int j = 2*i ;j <=size; j+=i){
        arr[j] = false;
      }
    }
     for(int k=0; k<size; k++){
      Console.WriteLine(k + " - "+ arr[k]);
    }
}
}