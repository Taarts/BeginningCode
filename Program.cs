using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
       Book book1 = new Book("Harry Potter", "Harry Potter", 452);
       Book book2 = new Book("The Two Towers", "Tolkien", 722);
       book2.title = "Return of the King";


     Console.WriteLine(book2.title);

     Console.ReadLine();
    }

    
  }
}
