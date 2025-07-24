using System;

class Reverse
{
  public void ReversedNumber()
  {
    int[] arr = { 1, 2, 3, 4, 5 };

    for (int i = arr.Length - 1; i >= 0; i--)
    {
      System.Console.WriteLine(arr[i]);
    }
  }
}