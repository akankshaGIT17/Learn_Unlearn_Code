

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

    public string MySolution(string[] listStrings)
    {// Fails for {"aaa","aa","aaa"}
        if (listStrings.Length == 0)
            return "";
        if (listStrings.Length == 1)
            return listStrings[0];
        string cur = listStrings[0];
        string s = "";
        for (int i = 1; i < listStrings.Length; i++)
        {
            s = string.Empty;
            for (int k = 0; k < listStrings[i].Length; k++)
            {
                if (k < s.Length && s[k] == listStrings[i][k])
                {
                    s = s + cur[k];

                }
                else break;
            }
        }
        Console.WriteLine(s);
        return string.Empty;
    }

    public void Caller()
    {
        string[] arr = {"flower","flow","flight"};
            //  Console.WriteLine(input);
        Console.WriteLine(LongestCommonPrefixFunc(arr));
    }

}
