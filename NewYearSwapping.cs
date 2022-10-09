using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    //https://www.hackerrank.com/challenges/new-year-chaos/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    public class NewYearChaos
    {
        int calcCount(int[] arr, int n)
        {
            var chaotic = false;
            var bribes = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] - (i + 1) > 2) { chaotic = true; }
                for (var j = Math.Max(0, arr[i] - 2); j < i; j++)
                {
                    if (arr[j] > arr[i]) { bribes++; }
                }
            }
            if (chaotic == true)
            {
                Console.WriteLine("Too chaotic");
                return 0;
            }
            return bribes;
        }
        public void caller()
        {

            int[] a = { 2, 1, 5, 3, 4 };
            int size = 5;
            int count = calcCount(a, size);
            Console.WriteLine("Couts " + count);

        }
    }
}
