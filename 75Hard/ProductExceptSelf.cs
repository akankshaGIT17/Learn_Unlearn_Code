using System;
//https://leetcode.com/problems/product-of-array-except-self/description/
namespace main.Array
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf_ConstantSpace(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];
            for (int i = 0; i < n; ++i) ans[i] = 1;

            int leftProduct = 1, rightProduct = 1;
            for (int i = 1, j = n - 2; i < n; ++i, --j)
            {
                leftProduct *= nums[i - 1];
                rightProduct *= nums[j + 1];
                ans[i] *= leftProduct;
                ans[j] *= rightProduct;
            }

            return ans;
        }
        public int[] ProductExceptSelfBigOofN(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int[] postFix = new int[nums.Length];
            int[] sol = new int[nums.Length];
          
            for (int i = nums.Length-1; i > 0; i--)
            {
                int num = i == nums.Length -1 ? 1 : postFix[i + 1];
                postFix[i] = num * nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int num = i == 0 ? 1 : prefix[i - 1];
                prefix[i] = num * nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int prefixVal = i == 0 ? 1 : prefix[i - 1];
                int postfixVal = i == nums.Length-1 ? 1 : postFix[i + 1];
                sol[i] = prefixVal * postfixVal;
            }
            return sol;
        }

        // Time limit exceeded. Below code is correct 
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] temp = new int[nums.Length];
            int count = 0;
            while (count < nums.Length)
            {
                int prod = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != count)
                    {
                        prod = prod * nums[i];
                    }
                }
                temp[count] = prod;
                count++;
            }
            return temp;
        }

        private void Print()
        {
            int[] input = { -1, 1, 0, -3, 3 };
            var result = ProductExceptSelfBigOofN(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public void Caller()
        {
            Print();
        }
    }
}
