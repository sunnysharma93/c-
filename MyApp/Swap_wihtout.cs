using System;

class Swaping
{
  public void SwapWithoutVariabel()
  {
    Console.WriteLine("Enter the value of a : ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the value of b : ");
    int b = Convert.ToInt32(Console.ReadLine());

    a = a + b;
    b = a - b;
    a = a - b;

    Console.WriteLine("After swaping two number ");
    Console.WriteLine("value of a : " + a + " value of b : " + b);
  }
}