using System;

class Odd
{
  public void Even_Odd_Number()
  {
    System.Console.WriteLine(" enter the any number");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
      System.Console.WriteLine(" even number");
    }
    else
    {
      System.Console.WriteLine("odd number");
    }
  }
}