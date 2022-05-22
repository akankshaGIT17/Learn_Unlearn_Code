using System;
using System.Collections.Generic;
using System.Linq;
public class BOILER{
public bool PRINT(string str){
  var len = str.Length;
  int[] a = {1,2,3,4,5};
  var arrLength = a.Length;
 Console.WriteLine("This is BOILER : "+ str );
 
     return true;
  
}
 public void Caller(){
    Console.WriteLine("Madam - "+PRINT("madam"));
  }
}