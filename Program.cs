using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
      int [,] numberGrid = {
        { 1, 2 },
        { 5, 6 },
        { 8, 9 }
      };

      Console.WriteLine(numberGrid[1, 1]);
    }

    
  }
}
