using System;
using System.Collections.Generic;

namespace hangman2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> randomWord = new List<string>();
            randomWord.Add("file");
            randomWord.Add("Edit");
            randomWord.Add("View");
            randomWord.Add("Project");
            randomWord.Add("Build");
            randomWord.Add("Debug");
            randomWord.Add("Analyze");
            randomWord.Add("Tools");
            randomWord.Add("Window");
            randomWord.Add("Fuck");

            int randomWordListCount = randomWord.Count;
            Random random = new Random();

            for (int K = 0; K < randomWordListCount; K++)
            {

                string secretWord = randomWord[K];






                List<string> guessList = new List<string>();
                Console.WriteLine("guess a letter");
                int secretWordLength = secretWord.Length;


                for (int i = 0; i < secretWordLength + 2; i++)

                {
                    string guess = Console.ReadLine();
                    guessList.Add(guess);



                    for (int j = 0; j < secretWordLength; j++)
                    {
                        string secretWordLetter = secretWord[j].ToString();


                        if (guessList.Contains(secretWordLetter))

                        {
                            Console.Write(secretWordLetter);
                        }
                        else
                        {
                            Console.Write("-");
                        }

                    }
                }
            }
        }
    }
}




