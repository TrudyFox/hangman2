using System;
using System.Collections.Generic;

namespace hangman2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();      //htat could be a function that returns a list of words
                                                             //htat could be a function that returns a list of words
                                                             //htat could be a function that returns a list of words
            wordList.Add("file");                            //htat could be a function that returns a list of words
            wordList.Add("edit");                            //htat could be a function that returns a list of words
            wordList.Add("view");                            //htat could be a function that returns a list of words
            wordList.Add("project");                         //htat could be a function that returns a list of words
            wordList.Add("build");                           //htat could be a function that returns a list of words
            wordList.Add("debug");                           //htat could be a function that returns a list of words
            wordList.Add("analyze");                         //htat could be a function that returns a list of words
            wordList.Add("tools");                           //htat could be a function that returns a list of words
            wordList.Add("window");                          //htat could be a function that returns a list of words
            wordList.Add("fuck");                            //htat could be a function that returns a list of words
            wordList.Add("duck :P");                         //htat could be a function that returns a list of words
            
            for (int K = 0; K < 5; K++)
            {
                string secretWord = getRandomWord(wordList);

                List<string> userGuesses = new List<string>();
                int secretWordLength = secretWord.Length;

                for (int i = 0; i < secretWordLength + 7; i++)   // number of guesses
                {
                    Console.WriteLine();
                    Console.WriteLine("guess a letter");                                     //this could be a function getUserGuess
                    string guess = Console.ReadLine();             // reads user guess       //this could be a function getUserGuess
                    userGuesses.Add(guess);

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
    }
}




