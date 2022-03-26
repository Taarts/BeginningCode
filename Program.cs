using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
     
      Chef chef = new Chef();
      chef.MakeChefSpecial();
      
      ItalianChef italianChef = new ItalianChef();
      italianChef.MakeChefSpecial();
     Console.ReadLine();
    }

    
  }
}
