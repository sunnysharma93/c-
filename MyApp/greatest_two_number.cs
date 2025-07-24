using System;

class Greater
{
  public void GreaterTwoNumber()
  {
    Console.WriteLine("Enter the first number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2)
    {
      Console.WriteLine("num1 is greater than num2");
    }
    else
    {
      Console.WriteLine("num2 is greatet than num 1");
    }

  }
}