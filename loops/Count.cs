using System;

class Count
{
  public void Count_Num()
  {
    System.Console.WriteLine(" Enter the number");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    if (number == 0)
    {
      count = 1;
    }
    else
    {
      while (number != 0)
      {
       number = number / 10;
        count++;

      }
    }
    System.Console.WriteLine("count digit number is " + count );
  }
}