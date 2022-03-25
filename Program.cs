using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
       Book book1 = new Book();
       book1.title = "Harry Potter";
       book1.author = "JK Rowling";
       book1.pages = 452;
      
       Book book2 = new Book();
       book2.title = "The Twin Towers";
       book2.author = "JRR Tolkien";
       book2.pages = 722;


       Console.WriteLine(book2.pages);
     
     Console.ReadLine();
    }

    
  }
}
