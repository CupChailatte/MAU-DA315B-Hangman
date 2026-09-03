using System;
using System.Text; 


class Program //class 
{
    //instanser 
    static void Main(string[]args) 
    {
        Console.WriteLine("Hello, Welcome to Hangman!"); 
        string secretWord = "spel"; //instansierar variablen av typen string

        StringBuilder displayString = new StringBuilder(); // Dynamisk Objekt - hanterar mutable/föränderlig strings 

        for (int i = 0; i < secretWord.Length; i++)
        {
            displayString.Append("_");  
        }
        int livesLeft = 5;
        Console.WriteLine(displayString);
        Console.WriteLine($"Du har {livesLeft} liv kvar!");
        Console.Write($"Gissa en bokstav:");
        string input = Console.ReadLine(); 
        char newChar = input[0];  
        bool rightLetter = false; 

        for(int i = 0; i < secretWord.Length; i++)
        {
            if (newChar == secretWord[i]) //kollar om char finns i något av indexet av secretWord
            {
             rightLetter = true; //    
            } 
        }
        
        if (rightLetter == true)
        {
         Console.WriteLine("You guessed right!"); 
        } 
         else
        {
            livesLeft--; 
            Console.WriteLine($"Wrong Letter! You have {livesLeft} lives left"); 
        }
    }
    
}





/* Glossor
Variables 
  string - rad av char - tar 1 byte/ 8bits 
  int 
  boolean 

Functions - A code that has a function to do something outside of a class 
Method - A function that belongs to a class 
Append() method - metod som lägger till något på slutet. 


Hårdkoda/hardcode - constant värde som är inte är optimalt. 

TERMINAL 
dotnet new console
dotnet run 

*/