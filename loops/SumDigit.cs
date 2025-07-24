using System;

class Sum
{
  public void SumDigit()
  {
    System.Console.WriteLine(" enter the number : ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    while (number != 0)
    {
      int digit = number % 10;
      sum += digit;
      number /= 10;

      System.Console.WriteLine("sum to digit number is : " + sum );
    }
  }
}