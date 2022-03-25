using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
     Student student1 = new Student("Marty", "Dance", 2.5);
     Student student2 = new Student("Precious", "Theoretical Physics", 4.0);
     
     Console.WriteLine(student1.HasHonors());
     Console.WriteLine(student2.HasHonors());

     Console.ReadLine();
    }

    
  }
}
