void Main()
{
	int[] ar = new int[] {1,2,3,4,3,2,1};
	int answer = Kata.FindEvenIndex(ar);
	Console.WriteLine(answer);
}

public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    for(var i = 0; i < arr.Length; i++)
    {
      if(arr.Take(i).Sum() == arr.Skip(i+1).Sum()) { return i; }
    }
    return -1;
  }
}
