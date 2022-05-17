//https://www.codingninjas.com/codestudio/problems/duplicate-in-array_893397?source=youtube&campaign=love_babbar_codestudio1&utm_source=youtube&utm_medium=affiliate&utm_campaign=love_babbar_codestudio1

using System;
public class DuplicateInArray{
  public void Caller (){
int[] arr ={6 ,3 ,1 ,5 ,4 ,3 ,2};
    var data = findDuplicate(arr);
   // Console.WriteLine(data);
}
public int findDuplicate(int[] arr) {
int ans=0;
  for(int i= 0; i<arr.Length; i++){
    ans = ans^arr[i];
    
  }
  Console.WriteLine(ans);
   for(int i= 1; i<arr.Length; i++){
    ans = ans^i;
    
  }
	return ans;
	}
  
  }
