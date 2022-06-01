using System;
using System.Collections.Generic;
using System.Linq;
public class MaximumSubArray{
public int MaxSubArray(int[] nums){
  int sum = 0;
	int maxSum = nums[0];

	for (int i=0; i<nums.Length; i++) {
		sum += nums[i];
		if (nums[i] > sum) {
			sum = nums[i];
		}
		if (sum > maxSum) { 
			maxSum = sum; 
		}
	}
	return maxSum;
}
 public void Caller(){
     int[] nums= {2,1,-3,4,-1,2,1,-5,4};
     
    Console.WriteLine(MaxSubArray(nums));
  }
}