using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.Hangman
{
    internal class HangmanUI : Hangman
    {
        public void GuessTheWord()
        {
            int notGuessedCharacters = CheckNotGuessCharactersCount();

            while (notGuessedCharacters > 0)
            {
                Console.WriteLine("\nplease guess the character or entire word");

                //Validate if user enters any value or not
                var usrGuessedWord = ValidateUserInputOnEmptyString().ToLower();
               
                int tempCount = 0;
                //If whole word is guessed complete the process
                if (WordToGuess == usrGuessedWord)
                {
                    Console.WriteLine($"congrats, you guessed the word {usrGuessedWord}");
                }

                //If entered more than 1 character and word is not guessed, asking user to enter only 1 character or guess the word again.
                else if (WordToGuess != usrGuessedWord && usrGuessedWord.Length > 1)
                {
                    Console.WriteLine($"sorry, you were not able to guess entire word, try again only with character or with entire word");
                }

                //If WordToGuess contains entered character, fill the UserGuessedArray appropriate index with this character
                else if (WordToGuess != usrGuessedWord && usrGuessedWord.Length == 1)
                {
                    //identify index of each char to copy to UsrGuessedArray
                    foreach (var usrStoredChar in UsrGuessedArray)
                    {
                        //Check if entered char is already guessed or not 
                        if (char.Parse(usrGuessedWord) == usrStoredChar)
                        {
                            Console.WriteLine($"you already guessed this char {usrGuessedWord}");
                            break;
                        }

                    }
                    //identify index and value of word chars to compare and copy to the same index to UsrGuessedArray
                    foreach (var (item, index) in SymbolsToGuess.Select((item, idx) => (item, idx)))
                    {
                        //Checking if user entered char is part of the word
                        if (char.Parse(usrGuessedWord) == item)
                        {
                            //Adding guessed char into UsrGuessedArray
                            UsrGuessedArray[index] = char.Parse(usrGuessedWord);
                            tempCount++;

                        }
                    }
                }

                //updating count of guess numbers
                notGuessedCharacters = CheckNotGuessCharactersCount();

                //checking if word is guessed or not completly
                if (notGuessedCharacters == 0 && tempCount > 0)
                {
                    Console.WriteLine($"congrats, you guessed the word:");
                    CheckGuessedWord();
                }

                //checking if word contains entered char
                else if (notGuessedCharacters >= 0 && tempCount == 0 && usrGuessedWord.Length == 1)
                {
                    Console.WriteLine($"Sorry, word does not contain {usrGuessedWord}");
                    Console.WriteLine();
                    CheckGuessedWord();
                }
                //confirming and unlocking the guessed char of the word.
                else if (notGuessedCharacters > 0 && tempCount > 0)
                {
                    Console.WriteLine($"Congrats, you guessed in total {WordToGuess.Length - notGuessedCharacters} characters of the word, " +
                        $"there is a left {notGuessedCharacters} characters:");
                    CheckGuessedWord();
                    Console.WriteLine();
                }
            }
        }

    }
}
