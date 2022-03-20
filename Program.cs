using System;

namespace BeginningCode
{
  class Program
  {
    static void Main(string[] args)
    {
      string secretWord = "secretword";
      string guess = "";
      int guessCount = 0;
      int guessLimit = 3;
      bool outOfGuesses = false;

      while(guess != secretWord && !outOfGuesses)

      {
        if(guessCount < guessLimit)
        {
          Console.Write("Enter guess: ");
          guess = Console.ReadLine();
          guessCount++;
        }
        else
        {
          outOfGuesses = true;
        }

      }
      if(outOfGuesses)
      {
      Console.Write("Oops, out of guesses");  
      }
      else
      Console.Write("Congrats, you win!");

      Console.ReadLine();

  

    
    }

  }
}
