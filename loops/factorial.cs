using System;

class Factorial
{
  public void Factorial_Num()
  {
    System.Console.WriteLine("Enter the number");
    int number = Convert.ToInt32(Console.ReadLine());

    long factorial = 1;

    for (int i = 1; i <= number; i++)
    {
      factorial *= i;
    }

    System.Console.WriteLine(" factorail " + number + " is " + factorial);
  }
}