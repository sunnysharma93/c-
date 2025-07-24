using System;

class Student
{
  private string name;
  private int age;

  public void SetDetails(string n, int a)
  {
    name = n;
    age = a;
  }
  public void ShowDetails()
  {
    System.Console.WriteLine("name " + name + "   age " + age );
  }
}