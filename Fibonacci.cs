using System;
using System.Collections.Generic;
using System.Linq;
public class Fibonacci{
    // ****************** Nth Fibacci number ************* 
public int fibRecursive(int n){
  if(n <1){
      return n;
  }
  return fibRecursive(n-1)+fibRecursive(n-2);
}
int fib(int n)
    {
         
        // Declare an array to
        // store Fibonacci numbers.
        // 1 extra to handle
        // case, n = 0
        int []f = new int[n + 2];
        int i;
         
        /* 0th and 1st number of the
           series are 0 and 1 */
        f[0] = 0;
        f[1] = 1;
         
        for (i = 2; i <= n; i++)
        {
            /* Add the previous 2 numbers
               in the series and store it */
            f[i] = f[i - 1] + f[i - 2];
        }
         
        return f[n];
    }
    // ****************** Nth Fibacci number ************* 
 public void Caller(){
    Console.WriteLine(fibRecursive(15));
  }
}