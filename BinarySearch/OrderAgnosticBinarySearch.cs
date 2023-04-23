public class OrderAgnosticBinarySearch{
  public void caller(){
    int[] a = { 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        int n = 18;
    Console.WriteLine(OrderAgnostic_BinarySearch(a,n));
  }
  
  public int OrderAgnostic_BinarySearch(int[] arr, int element){
    int start = 0;
    int end = arr.legnth-1;
    bool isAsc= arr[start] < arr[end];
    while(start <= end){
      while( start < end){
        
        int mid = start + ( start - end ) / 2;
       
        if(element == arr[mid]){
          return mid;
        }
        
        if( element < arr[mid]){
          
          if(isAsc){
          end = mid -1 ;
          }
          else{
          start = mid + 1;
          }
      }
        else if( element > arr[mid]){ {
          end = mid - 1;
        }
          else {
          start = mid+ 1;
          }
       
      }
    }
    return -1;
  }
}
