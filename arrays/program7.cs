using System;

class Search
{
  public void SearchNumber()
  {
    int[] arr = { 1, 2, 3, 6, 7, 5 };
     int search = 8;
    bool found = false;
    foreach (int num in arr)
    {
      if (num == search)
      {
        found = true;
        break;
      }
    }
    System.Console.WriteLine(found + " found number");
  }
}