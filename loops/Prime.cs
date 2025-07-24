using System;

class Prime
{
  public void PrimeNumber()
  {
    System.Console.WriteLine(" Enter the any numner");
    int number = Convert.ToInt32(Console.ReadLine());
    bool isPrime = true;

    if (number <= 1)
    {
      isPrime = false;
    }
    else
    {
      for (int i = 2; i <= Math.Sqrt(number); i++)
      {
        if (number % i == 0)
        {
          isPrime = false;
          break;
        }
      }
    }
    if (isPrime)
    {
      System.Console.WriteLine(number + " prime number");
    }
    else
    {
      System.Console.WriteLine(number + " not prime number");
    }
  }
}