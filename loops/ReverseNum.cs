using System;

class Reverse
{
  public void Reverse_Num()
  {
    System.Console.WriteLine(" Enter the number");
    int number = Convert.ToInt32(Console.ReadLine());

    int reversed = 0;

    while (number != 0)
    {
      int digit = number % 10;
      reversed = reversed * 10 + digit;
      number = number / 10;
    }
    System.Console.WriteLine("Reversed number is "  + reversed);
  }
}