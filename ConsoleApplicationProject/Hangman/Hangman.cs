using ConsoleApplicationProject.MenuAndHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.Hangman
{
    internal class Hangman : Validators
    {

        public string WordToGuess { get; set; }

        public char[] SymbolsToGuess { get; set; }

        public char[] UsrGuessedArray { get; set; }

        //public int GuessedCharacters { get; set; }


        public Hangman()
        {
          
            GenerateArrayOfGuessWord();
        }

        public char[] SelectingWordToGuess()

        {
            Random random = new Random();
            WordsToGuess wordsToGuess = new WordsToGuess();
            int wordIndext = random.Next(0, wordsToGuess.LengthOfTheWordsList());

            WordToGuess = wordsToGuess.GetWord(wordIndext);
            return WordToGuess.ToCharArray(); 

        }
        public void GenerateArrayOfGuessWord()
        {
            
            //Filling array based on WordToGuess property
            SymbolsToGuess = SelectingWordToGuess();

            //print dashes based on word length.
            for (int i = 0; i < SymbolsToGuess.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            //Generate empty array to store user guessed characters and compare it to original array
            UsrGuessedArray = new char[SymbolsToGuess.Length];
        }

        public int CheckNotGuessCharactersCount()
        {
            int notGuessedCharactersTemp = 0;
            foreach (var i in UsrGuessedArray)
            {
                if (i == default(char))
                {
                    notGuessedCharactersTemp++;
                }
            }
            return notGuessedCharactersTemp;

        }

        public void CheckGuessedWord()
        {
            foreach (var i in UsrGuessedArray)
            {
                if (i == default(char))
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write(i);

                }
            }
        }
    }
}

