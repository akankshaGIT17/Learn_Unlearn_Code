using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/add-strings/
//NOT my solution
public class AddString
{
    public string Calculate(string num1, string num2)
    {
           int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
        StringBuilder sb = new StringBuilder();
        
        while(i >= 0 || j >= 0 || carry == 1)
        {
            int d1 = i < 0? 0 : num1[i] - '0';
            int d2 = j < 0? 0 : num2[j] - '0';

            int sum = d1 + d2 + carry;            
            sb.Insert(0, sum % 10);
            
            carry = sum / 10;
            i--;
            j--;
        }
        
        return sb.ToString();
    }

    public void Caller()
    {
            //  Console.WriteLine(input);
        Console.WriteLine(Calculate("12", "13"));
    }
}