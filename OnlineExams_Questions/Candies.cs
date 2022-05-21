//https://www.geeksforgeeks.org/distribute-n-candies-among-k-people/#:~:text=Given%20N%20candies%20and%20K,2%20candies%2C%20and%20so%20on.
// Given N candies and K people. In the first turn, the first person gets 1 candy, the second gets 2 candies, and so on till K people. In the next turn, the first person gets K+1 candies, the second person gets k+2 candies, and so on
// Input: N = 7, K = 4 
// Output: 1 2 3 1 
// At the first turn, the fourth people has to be given 4 candies, but there is 
// only 1 left, hence he takes one only. 
// Input: N = 10, K = 3 
// Output: 5 2 3 
// At the second turn first one receives 4 and then we have no more candies left. 

using System;
public class Candies
{
    // Function to find out the number of
    // candies every person received
    public void candies(int n, int k)
    {
     
        // Count number of complete turns
        int count = 0;
     
        // Get the last term
        int ind = 1;
     
        // Stores the number of candies
        int []arr=new int[k];
      
        for(int i=0;i<k;i++)
         arr[i]=0;
      
     
        int low = 0, high = n;
     
        // Do a binary search to find the number whose
        // sum is less than N.
        while (low <= high) {
     
            // Get mide
            int mid = (low + high) >> 1;
            int sum = (mid * (mid + 1)) >> 1;
     
            // If sum is below N
            if (sum <= n) {
     
                // Find number of complete turns
                count = mid / k;
     
                // Right halve
                low = mid + 1;
            }
            else {
     
                // Left halve
                high = mid - 1;
            }
        }
     
        // Last term of last complete series
        int last = (count * k);
     
        // Subtract the sum till
        n -= (last * (last + 1)) / 2;
     
        int j = 0;
     
        // First term of incomplete series
        int term = (count * k) + 1;
     
        while (n > 0) {
            if (term <= n) {
                arr[j++] = term;
                n -= term;
                term++;
            }
            else {
                arr[j] += n;
                n = 0;
            }
        }
     
        // Count the total candies
        for (int i = 0; i < k; i++)
            arr[i] += (count * (i + 1))
                + (k * (count * (count - 1)) / 2);
     
        // Print the total candies
        for (int i = 0; i < k; i++)
            Console.Write( arr[i] + " " );
    }

  public void Caller()
  {
     int n = 7, k = 4;
        candies(n, k);
  }
}