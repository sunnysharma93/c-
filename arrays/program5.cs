using System;

class Number
{
  public void MaxMinNumber()
  {
    int[] arr = { 25, 32, 5, 3, 6, 199 };
    int max = arr[0];
    int min = arr[0];

    foreach (int num in arr)
    {
      if (num > max)
      {
        max = num;
      }
      else if (num < min)
      {
        min = num;
      }
    }
    System.Console.WriteLine(max);
    System.Console.WriteLine(min);

  }
}