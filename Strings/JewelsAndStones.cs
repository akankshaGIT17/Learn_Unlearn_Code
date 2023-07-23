using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/jewels-and-stones/description/
namespace main.Strings
{
    public class JewelsInStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> charHash = new HashSet<char>(jewels);
            int count = 0;

            foreach (char c in stones)
            {
                if (charHash.Contains(c))
                    count++;
            }

            return count;

        }
        public void Print()
        {
            string jewels = "aA", stones = "aAAbbbb";
            Console.WriteLine(NumJewelsInStones(jewels, stones));
        }
        public void Caller()
        {
            Print();
        }
    }
}
