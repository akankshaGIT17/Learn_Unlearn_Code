using System;
public class PalindromicSubstrings{
   public int Substrings(string s) {
        int count = s.Length;
        for(int i = 0; i < count; i++) {
            int start = i, end = i;
          Console.WriteLine("------------ iteration-------- " +i);
          Console.WriteLine("End before while " +end);
            while(end < s.Length -1 && s[end] == s[end+1]) {
                    end++;
                    count++;
              Console.WriteLine("End in while " +end);
              Console.WriteLine("End var  " +s[end]);
              Console.WriteLine("Count in while " +count);
            }
            while(end < s.Length-1 && start > 0 && s[start-1] == s[end+1]) {
                start--; 
                end++;
                count++;
               Console.WriteLine("End in 2nd while " +end);
              Console.WriteLine("End var 2nd " +s[end]);
              Console.WriteLine("Start in 2nd while " +start);
              Console.WriteLine("Start var 2nd " +s[start]);
              Console.WriteLine("Count in 2nd while " +count);
            }
        }
        return count;
    }
  public void Caller(){
  var t = Substrings("aaabbbaaa");
    Console.WriteLine(t);
  }
  }
