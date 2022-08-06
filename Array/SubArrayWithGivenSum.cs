namespace main.Array
{
    //https://www.geeksforgeeks.org/find-subarray-with-given-sum/
   public class SubArrayWithGivenSum
    {
        public bool PRINT(int[] a)
        {
            int[] arr = { 2, 7, 11, 15 };
            int sum = 9;
            int left = 0;
            int right = 0;
            int cur_sum = arr[left];
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[left] + "+ " + arr[right] + "=" + cur_sum);
                while (cur_sum < sum)
                {
                    Console.WriteLine("right to move " + cur_sum);
                    right = right + 1;
                    cur_sum = cur_sum + arr[right];
                }
                while (cur_sum > sum && left < right)
                {
                    Console.WriteLine("left to move " + cur_sum);
                    cur_sum = cur_sum - arr[left++];
                }

                if (cur_sum == sum)
                {
                    break;
                }
            }
            Console.WriteLine("Left index is " + left);
            Console.WriteLine("Right index is " + right);

        }
    }
}
