using System;
using System.Collections.Generic;
using System.Linq;
public class ContainsDuplicate{
public int PRINT(int[] a){
  var arrLength = a.Length;
  int ans=0;
 for(var i=0; i<arrLength; i++){
ans= ans^a[i];
 }
 
     return ans;
  
}
 public void Caller(){
     int[] a = {1,2,3,4,5};
    Console.WriteLine("Madam - "+PRINT(a));
  }
}