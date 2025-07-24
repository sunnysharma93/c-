// print the multiplication table of 5

using System;

class Table
{
  public void Multiplication_Table()
  {
    int num = 5;

    System.Console.WriteLine("multiplicaton number is " + num + " : ");

    for (int i = 1; i <= 10; i++)
    {
      System.Console.WriteLine(num + "x" + i + " = " + (num*i) );
    }
    
  }
}