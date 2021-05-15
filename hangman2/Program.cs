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
            randomWord.Add("edit");
            randomWord.Add("view");
            randomWord.Add("project");
            randomWord.Add("build");
            randomWord.Add("debug");
            randomWord.Add("analyze");
            randomWord.Add("tools");
            randomWord.Add("window");
            randomWord.Add("fuck");

            Random random = new Random();
                    // int randomWordListCount = Random.Next(randomWord.Count);    < trying to use random.Next as my list runs in order
            int randomWordListCount = randomWord.Count;

            for (int K = 0; K < randomWordListCount; K++)
            {
                
                string secretWord = randomWord[K];
                


                List<string> secretListWord = new List<string>();
                Console.WriteLine("guess a letter");
                int secretWordLength = secretWord.Length;


                for (int i = 0; i < secretWordLength + 7; i++)   // number of guesses

                {
                    string guess = Console.ReadLine();             // reads user guess
                    secretListWord.Add(guess);


                    
                    bool Win = true;
                    for (int j = 0; j < secretWordLength; j++)    // loops through each letter of secret word
                    {
                        string secretWordLetter = secretWord[j].ToString();
                        if (secretListWord.Contains(secretWordLetter))               // prints out letter or -
                           
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
                            Console.Write("You Win");
                        break;

                        }
                }
            }
        }
    }
}




