using System;

class Array
{
  public void ArrayStore()
  {
    int[] num = new int[5];

    System.Console.WriteLine(" enter the number ");
    for (int i = 1; i <= num.Length; i++)
    {
      // System.Console.WriteLine("numbers" + (i) + " : ");
      System.Console.WriteLine($"number s{i} :");

      num[i] = Convert.ToInt32(Console.ReadLine());

    }
    System.Console.WriteLine(" entered");
    for (int i = 1; i <= num.Length; i++)
    {
        System.Console.WriteLine("total number " + i + " : " + num[i]);

    }

  }
}