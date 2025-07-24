using System;

class Swapping
{
  public void SwapTwoNumber()
  {
    int a = 32;
    int b = 15;
    Console.WriteLine("before swap value of a : " + a + " value of b : " + b);

    int temp;

    temp = a;
    a = b;
    b = temp;

    Console.WriteLine("value of a is : " + a + " value of b is : " + b);
  }
}