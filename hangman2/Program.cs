using System;
using System.Collections.Generic;
using System.Linq;

namespace hangman2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int K = 0; K < 5; K++)
            {
                string secretWord = getRandomWord(getWordList());
                List<string> userGuesses = new List<string>();
                int secretWordLength = secretWord.Length;


                for (int i = 0; i < secretWordLength + 7; i++)   // number of guesses
                {
                    userGuesses.Add(userGuessOutput());
                    bool Win = true;

                    //(rough) suggestion  printCurrentGameState()
                    for (int j = 0; j < secretWordLength; j++)    // loops through each letter of secret word and prints it out or prints "-"
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
                        displayWinningScreen();
                        break;
                    }
                }
            }
        }

        private static string getRandomWord(List<string> wordList)
        {
            int wordListCount = wordList.Count;
            Random random = new Random();
            int randomIndex = random.Next(wordListCount);
            string randomWord = wordList[randomIndex];

            return randomWord;
        }

        private static void displayWinningScreen()
        {
            Console.Clear();
            Console.WriteLine();         //winning screen
            Console.Write("You Win");    //winning screen
            Console.WriteLine();
        }

        private static List<string> getWordList()

        {
            string[]wordList = System.IO.File.ReadAllLines(@"C:\Users\Trudy\OneDrive\Documents\Color Text File.txt");

            return wordList.ToList();
        }

        private static string userGuessOutput()
        {
            Console.WriteLine();
            Console.WriteLine("guess a letter");
            string guess = Console.ReadLine();             // reads/outputs user guess     

            return guess;
        }




    }
}

