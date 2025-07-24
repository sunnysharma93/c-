// print the all even number 1 to 100

using System;

class Number
{
  public void EvenNumber()
  {
    for (int i = 1; i <= 100; i++) 
    {
      if (i % 2 == 0)
      {
        System.Console.WriteLine(i);
      }
      
    }

  }
}