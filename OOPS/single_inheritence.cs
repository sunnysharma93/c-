using System;

class Animal
{
  public void Eat()
  {
    System.Console.WriteLine("eating");
  }
}

class Dog : Animal
{
  public void Bark()
  {
    System.Console.WriteLine("barking");
  }
}