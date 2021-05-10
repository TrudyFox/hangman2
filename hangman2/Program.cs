using System;
using System.Collections.Generic;

namespace hangman2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> guessList = new List<string>();

            string secretWord = "hippo";
            int secretWordLength = secretWord.Length;
            bool isWin = false;

            Console.WriteLine("guess a letter");


            for (int i = 0; i < secretWordLength + 2; i++)        // how many guesses player gets
            {
                string guess = Console.ReadLine();   // guess input and List var
                guessList.Add(guess);



                for (int j = 0; j < secretWordLength; j++)          // loops through each letter of secret word
                {
                    string secretWordLetter = secretWord[j].ToString();  // turns int to string 

                    if (guessList.Contains(secretWordLetter))       // looks into list for a letter in secret word
                    {
                        Console.Write(secretWordLetter);

                    }
                    else
                    {
                        Console.Write("-");
                    }

                    //if (guessList.Contains(secretWordLetter))
                    //{
                    //    Console.Write("You Win!!");

                    //}
                    //else
                    //{
                    //    Console.Write("You Lose");
                    //}

                }
            }
        }


    }
}
