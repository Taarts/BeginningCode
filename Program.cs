using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    { 
      bool isHungry = false;
      bool isTall = false;
      
      if (isHungry && isTall) 
      {
        Console.WriteLine("You are a hungry person");
      } else if (isHungry && !isTall){
        Console.WriteLine("You are a hungry person but you are not tall");
         } else if (!isHungry && isTall){
        Console.WriteLine("You are not a hungry person but you are tall");
      }else

       {
        Console.WriteLine("You are neither hungry nor tall");

      } 
      Console.ReadLine();

    }

  }
}
