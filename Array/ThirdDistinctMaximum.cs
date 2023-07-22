using System;

namespace main.Array
{
    public class ThirdDistinctMaximum
    {
        private int ThirdDistinctNumber(int[] nums)
        {

            int max1 = -1, max2 = -1, max3 = -1;
            if (nums.Length == 1)
                return nums[0];
            else if (nums.Length == 2)
                return (nums[0] > nums[1] ? nums[0] : nums[1]);
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (max1 == -1)
                        max1 = i;
                    else
                    {
                        if (nums[i] > nums[max1])
                        {
                            max3 = max2;
                            max2 = max1;
                            max1 = i;
                        }
                        else if (nums[i] != nums[max1])
                        {
                            if (max2 == -1)
                                max2 = i;
                            else
                            {
                                if (nums[i] > nums[max2])
                                {
                                    max3 = max2;
                                    max2 = i;
                                }
                                else if (nums[i] != nums[max2])
                                {
                                    if (max3 == -1)
                                        max3 = i;
                                    else if (nums[i] > nums[max3])
                                        max3 = i;
                                }
                            }
                        }
                    }
                }
            }

            if (max3 != -1)
                return nums[max3];
            else return nums[max1];
        }
        private void PrintResult()
        {
            int[] arr = { 1, 2, -2147483648 };
            if (arr.Length < 1)
                Console.WriteLine("No inpumax3provided");
            Console.WriteLine(ThirdDistinctNumber(arr));
        }
        public void Caller()
        {
            this.PrintResult();
        }

    }

}
