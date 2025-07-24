using System;
using System.Runtime.ConstrainedExecution;

class User
{
  public void UserInput()
  {
    System.Console.WriteLine(" enter the first number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("enter the second number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int result = num1 + num2;
    System.Console.WriteLine("result = " + result);
  }
}
