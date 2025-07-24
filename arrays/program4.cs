using System;

class Sum
{
  public void SumArray()
  {
    int[] arr = { 1, 2, 3, 4, 5 };
    int sum = 0;

    foreach (int num in arr)
    {
      sum += num;
    }
    System.Console.WriteLine(sum);
  }
}