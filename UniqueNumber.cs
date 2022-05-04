// https://leetcode.com/problems/unique-number-of-occurrences/
using System;
using System.Collections.Generic;
using System.Linq;

public class UniqueNumber
{
  public void Caller(){
    int[] arr ={1,2,2,1,1,3};
    var output = UniqueOccurrences(arr);
    var o2=  UniqueOccurrencesSmall(arr);
    Console.WriteLine(o2);
  }
public bool UniqueOccurrences(int[] arr) {
	Dictionary<int, int> counts = new Dictionary<int, int>();
	foreach (int n in arr) {
		if (counts.ContainsKey(n)) {
			counts[n]++;
		}
		else {
			counts[n] = 1;
		}
	}

	HashSet<int> unique = new HashSet<int>();
	foreach (int key in counts.Keys) {
		if (unique.Contains(counts[key])) return false;
		unique.Add(counts[key]);
	}

	return true;
}
   public bool UniqueOccurrencesSmall(int[] arr) {
     return arr.GroupBy(x => x).GroupBy(x => x.Count()).All(x => x.Count() == 1);
    }
  
}
