

using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/longest-common-prefix/
//NOT my solution
public class LongestCommonPrefix{
public string LongestCommonPrefixFunc(string[] strs) {
    if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
            return "";
        string res = strs[0];
        int i = res.Length;
        foreach (string word in strs) {
            int j = 0;
            foreach (char c in word) {
                if (j >= i || res[j] != c)
                    break;
                j += 1;
            }
            i = Math.Min(i, j);
        }
        return res.Substring(0, i);
    }
 public void Caller()
    {
        string[] arr = {"flower","flow","flight"};
            //  Console.WriteLine(input);
        Console.WriteLine(LongestCommonPrefixFunc(arr));
    }

}
