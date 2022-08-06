using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.SDESheets.Faraz
{
    public class BuySellStocks
    {
        public void BuySell()
        {
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            int min=arr[0];
            int position = 0;
            int prev = 0;
            int res = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                Console.WriteLine("Subtract " + arr[i] + " - " + min + "=" + (arr[i] - min));
                if (arr[i] - min > prev)
                {
                    prev = arr[i] - min;
                }
            }
            Console.WriteLine(prev);
        }
    }
}
