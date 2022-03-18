using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    { 
    
      SayHi("Nick", 54);
      SayHi("Mick", 20);
      SayHi("Vick", 19);
      Console.ReadLine();

    }

    static void SayHi(string name, int age) 
    {
      Console.WriteLine("Hello " + name + ", you are " + age);

    }

  }
}
