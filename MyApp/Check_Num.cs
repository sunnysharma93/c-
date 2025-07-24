// CHECK THE NUMBER IS POSITVE , NEGATIVE AND ZERO

using System;

class CheckNum
{
  public void CheckNumber()
  {
    Console.WriteLine("Enter the any number");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0)
    {
      Console.WriteLine(" the number is positive");

    }
    else if (number < 0)
    {
      Console.WriteLine("the number is negative");
    }
    else
    {
      Console.WriteLine("the number is zero");
    }
  }
}