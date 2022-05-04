//From leetcode: https://leetcode.com/problems/reverse-integer/
// Reverse intergr if it goes outside range of 32 bit int then return zero
//123->321
using System;
public class ReverseInteger{
public void reverseInt(){
  int a= -2147483648;
  int result = 0;
  
  while (a > 0)
            {
                int b = a % 10;
                if ((result > Int32.MaxValue / 10) || (result < Int32.MinValue/10))
                {
                    Console.WriteLine("Value exceeded");
                }
                result = (result * 10) + b;
                a = a / 10;
              
            }
              Console.WriteLine(result);
}
}