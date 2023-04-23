public class PeakElement{
public void caller(){
 int[] a = { 5,4,3,2,1 };
		int peakNumber = peakElement(a);
		Console.WriteLine(a[peakNumber]);
}
public int peakElement(int[] arr)
	{
		int start = 0;
		int end = arr.Length - 1;
		while (start < end)
		{
			int mid = start + (end - start) / 2;
				if (arr[mid] > arr[mid + 1])
				{
					// you are in desc aprt of array this may be the answer but look at left
					end = mid;
				}
				else
				{
					start = mid + 1;
				}
		}
			return start;
	}
}
