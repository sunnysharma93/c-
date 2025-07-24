using System;

class Program
{
  static void Main(string[] args)
  {
    // Student s = new Student();
    // s.SetDetails("sunny", 21);
    // s.ShowDetails();

    // Animal animal = new Animal();
    // animal.animalsound();
    // animal.sleep();

    // Dog d = new Dog();
    // d.Eat();
    // d.Bark();

    // Satyam s = new Satyam();
    // s.name();
    // s.name1();
    // s.name2();

    Calculator cal = new Calculator();
    System.Console.WriteLine(cal.add(5, 7));
    System.Console.WriteLine(cal.add(2.3 ,4.5));
    System.Console.WriteLine(cal.add(5,7,2));
  }
}