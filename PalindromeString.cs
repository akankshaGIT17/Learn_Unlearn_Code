using System;
public class PalindromeString
{
    public bool Palindrome(string str)
    {
        // Pointers pointing to the beginning
        // and the end of the string
        int i = 0, j = str.Length - 1;

        // While there are characters to compare
        while (i < j)
        {

            // If there is a mismatch
            if (str[i] != str[j])
                return false;

            // Increment first pointer and
            // decrement the other
            i++;
            j--;
        }

        // Given string is a palindrome
        return true;
    }
    public void Caller()
    {
        string[] palindromeString = { "abba", "madam", "chuku", "nun", "abcabc", "maam" };
        foreach (var str in palindromeString)
        {
            //test from vs codes
            Console.WriteLine(str+ ": "+ Palindrome(str));
        }
    }
}
