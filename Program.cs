using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    { 
      bool isHungry = false;
      bool isTall = false;
      
      if (isHungry || isTall) 
      {
        Console.WriteLine("You are a hungry person");

      } else
       {
        Console.WriteLine("You are either not hungry or not tall or both");

      } 
      Console.ReadLine();

    }

  }
}
