using System;

namespace main.Strings
{
    //Add two string numbers and the result should also be string.
    internal class StringAddition
    {
        public string stringAddition(string num1, string num2)
        {
            char[] output = new char[Math.Max(num1.Length, num2.Length) + 1];
            bool carry = false;
            int position = 0;

            for (int first = num1.Length - 1, second = num2.Length - 1;
                 first >= 0 || second >= 0;
                 first--, second--)
            {

                int result = (first >= 0 ? num1[first] - '0' : 0) +
                    (second >= 0 ? num2[second] - '0' : 0) +
                    (carry ? 1 : 0);
                carry = result >= 10;
                output[(output.Length - 1) - position++] = (char)('0' + (result % 10));
            }

            if (carry)
            {
                output[0] = '1';
            }

            return new string( output, carry ? 0 : 1,
            carry ? output.Length : output.Length - 1);
        }
    
        public void Caller()
        {
            string s1 = "11";
            string s2 = "123";
            Console.WriteLine(stringAddition(s1, s2));
        }
    }
}

