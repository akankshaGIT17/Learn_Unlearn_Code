using System;
public class PowerOfTwo{
  public void power(){
    // Loop mein gae kyunki % (mod) ke through 
    // 14%2 = 0  && 16%2=0 hota hai but 14 2 ki kisi bhi power mein nhi ata.
    // Isisli lie loop mein chalenge jaha humein max 31 tak ki power ki range di hai, har 1-31 tak 2 pi pow nikalenge aur compare krenge. 
    //Aur divide krenge (/) naki %. Jab / krne pke 1 ae to solve ho gaya.
    // brute force
    //ans = 1;
    // for(1 to 31)
    //ans = pow(2,i)
    //if ans == n ; to solve ho gaya
    int ans=1;
    int n=1233212;
       for (int i=0;i<=30;i++){
           if(ans==n){
              Console.WriteLine("True");}
           if(ans < (Int32.MaxValue/2))
           ans=ans*2;
       }
       Console.WriteLine("False");
    }
}
//Using Bitwise
//-1
// public class Solution {
//     public bool IsPowerOfTwo(int n) {
//         return n > 0 && (n & (n - 1)) == 0;
//     }
// }
//-2
//    public bool IsPowerOfTwo(int n) {
//         if(n==0)
//             return false;
//         if(n==1)
//             return true;
//         while(n!=1)
//         {
//             if(n%2!=0)
//                 return false;
//             n/=2;
//         }
//         return true;
//     }
// }