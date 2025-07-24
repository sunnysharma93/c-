using System;

class Declare
{
  public void DeclareArray()
  {
    int[] arr = { 1, 2, 3, 4, 5, 5 };

    foreach(int num in arr) {
      System.Console.WriteLine(num);
    }
  }
}