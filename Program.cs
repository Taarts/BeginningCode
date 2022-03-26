using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
     Movie avengers = new Movie("The Avengers", "Joss Whedon", "R");
     Movie adam = new Movie("The Adam Project", "AP Earson", "PG-13");
     
     Console.WriteLine(avengers.Rating);
     Console.ReadLine();
    }

    
  }
}
