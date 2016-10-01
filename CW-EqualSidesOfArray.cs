/*
Description:
You are going to be given an array of integers. Your job is to take that array and find an index N where the sum of the integers to the left of N is equal to the sum of the integers to the right of N. If there is no index that would make this happen, return -1.
For example:

Let's say you are given the array {1,2,3,4,3,2,1}:
Your function will return the index 3, because at the 3rd position of the array, the sum of left side of the index ({1,2,3}) and the sum of the right side of the index ({3,2,1}) both equal 6.

Let's look at another one.
You are given the array {1,100,50,-51,1,1}:
Your function will return the index 1, because at the 1st position of the array, the sum of left side of the index ({1}) and the sum of the right side of the index ({50,-51,1,1}) both equal 1.

Note: Please remember that in most programming/scripting languages the index of an array starts at 0.
Input:

An integer array of length 0 < arr < 1000. The numbers in the array can be any integer positive or negative.
Output:

The lowest index N where the side to the left of N is equal to the side to the right of N. If you do not find an index that fits these rules, then you will return -1.
Note:

If you are given an array with multiple answers, return the lowest correct index.
*/

public void Main()
	{
		int[] ar = new int[] {1,2,3,4,3,2,1};
		int answer = Kata.FindEvenIndex(ar);
		Console.WriteLine(answer);
	}

public class Kata
{

  public static int FindEvenIndex(int[] arr)
  {
    // find index n where sum[0,...,n-1] == sum[n+1,...,end]
    // if multiples, find first occurrance
    // split array at pivot point into two
    // add each side of the resulting arrays
    int lastIndex = arr.Length-1;
    if (lastIndex < 2) return -1; // must have 3+ elements
    for (int i=1;i<lastIndex;i++) {
      // split around i
      int frontLength = i;
      int backLength = lastIndex-i;
      int[] front = new int[frontLength];
      int[] back = new int[backLength];
      
      // copy elements into front, back
      System.Array.Copy(arr,0,front,0,frontLength);
      System.Array.Copy(arr,i+1,back,0,backLength);
      Console.WriteLine(front);
	  Console.WriteLine(back);
      // sum and compare front, back
      if (sumArray(front) == sumArray(back)) {
        return i;
      }
       
    } // for
    return -1;
  } // FindEvenIndex
  
  public static int sumArray(int[] ar) {
    int sum = 0;
    for (int i=0;i<ar.Length;i++) {
      sum += ar[i];
    }
    return sum;
  }
}
