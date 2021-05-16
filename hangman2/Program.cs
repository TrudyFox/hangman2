using System;
using System.Collections.Generic;

namespace hangman2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();


            wordList.Add("file");
            wordList.Add("edit");
            wordList.Add("view");
            wordList.Add("project");
            wordList.Add("build");
            wordList.Add("debug");
            wordList.Add("analyze");
            wordList.Add("tools");
            wordList.Add("window");
            wordList.Add("fuck");



            int wordListCount = wordList.Count;
            Random random = new Random();
            for (int K = 0; K < 5; K++)
            {
                int randomIndex = random.Next(wordListCount);

                string secretWord = wordList[randomIndex];

                List<string> userGuesses = new List<string>();
                Console.WriteLine("guess a letter");
                int secretWordLength = secretWord.Length;

                for (int i = 0; i < secretWordLength + 7; i++)   // number of guesses
                {
                    string guess = Console.ReadLine();             // reads user guess
                    userGuesses.Add(guess);

                    bool Win = true;
                    for (int j = 0; j < secretWordLength; j++)    // loops through each letter of secret word
                    {
                        string secretWordLetter = secretWord[j].ToString();
                        if (userGuesses.Contains(secretWordLetter))               // prints out letter or -
                        {
                            Console.Write(secretWordLetter);
                        }
                        else
                        {
                            Console.Write("-");
                            Win = false;
                        }
                    }
                    if (Win == true)
                    {
                        Console.WriteLine();
                        Console.Write("You Win");
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}




