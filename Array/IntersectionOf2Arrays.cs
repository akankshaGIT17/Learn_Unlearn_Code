using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Array
{
   public class IntersectionOf2Arrays
    {
        int getIntersection(int[] ar1, int m, int[] ar2, int n)
        {
            int i = j = 0;
            List<int> res = new List<int>();
            while (i<m && j < n)
            {
                if(ar1[i] == ar2[j])
                {
                    res.Add(arr1[i]);
                    i ++; j++;
                }
                if(ar1[1]< ar1[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }

            }
            return res;

        }
        List<int> BasicSolution(int[] ar1, int[] ar2)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < ar1.Length; i++)
            {
                for (int k = 0; k < ar2.Length; k++)
                {
                    if (ar1[i] == ar2[k])
                    {
                        res.Add(ar1[i]);
                        ar2[k] = -1;
                        break;  
                    }
                }
            }
            return res;
        }
        void Caller()
        {
            int[] ar1 = { 1, 2, 3, 4, 5 };
            int[] ar2 = { 2, 4, 3 };
            int m = ar1.Length;
            int n = ar2.Length;
            var res = getIntersection(ar1,m,ar2,n);
        }
    }
}
