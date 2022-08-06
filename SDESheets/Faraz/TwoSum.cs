using System;
using System.Collections.Generic;

namespace main.SDESheets.Faraz
{
    public class TwoSum
    {
        public int[] TwoSumCalc(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Key: " + (target - nums[i]));
                if (seen.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, seen[target - nums[i]] };
                }
                else
                {
                    Console.WriteLine("seen[nums[i]] = "+ seen[nums[i]] +" i " + i);
                    seen[nums[i]] = i;
                }
            }
            return new int[2];
        }
        public void Caller()
        {
            int[] a = {3,6,3 };
            int target = 9;
            var res = TwoSumCalc(a, target);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);

        }
    }
}
