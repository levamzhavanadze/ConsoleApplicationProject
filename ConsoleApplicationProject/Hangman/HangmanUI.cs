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
                Console.WriteLine("please guess the character or entire word");

                //Validate if user enters any value or not
                var usrGuessedWord = ValidateUserInputOnEmptyString();

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
                    int tempCount = 0;
                    foreach (var (item, index) in SymbolsToGuess.Select((item, idx) => (item, idx)))
                    {
                        //დასამატებელია ერთიდაიგივე სიმბოლოს შეყვანაზე შემოწმება
                        //foreach (var (usrItem, usrIndex) in UsrGuessedArray.Select((item, idx) => (item, idx)))
                        //{
                        //    if (index == usrIndex && item == usrItem)
                        //    {
                        //        sameGuessedCharacter = true;
                        //    }
                        //    else
                        //    {
                        //        if (char.Parse(usrGuessedWord) == item)
                        //        {
                        //            UsrGuessedArray[index] = item;
                        //        }
                        //    }
                        //}

                        if (char.Parse(usrGuessedWord) == item)
                        {
                            UsrGuessedArray[index] = char.Parse(usrGuessedWord);
                            tempCount++;
                        }
                    }

                    notGuessedCharacters = CheckNotGuessCharactersCount();


                    if (notGuessedCharacters == 0 && tempCount > 0)
                    {
                        Console.WriteLine($"congrats, you guessed the word:");
                        CheckGuessedWord();

                    }
                    else if (notGuessedCharacters >= 0 && tempCount == 0)
                    {
                        Console.WriteLine($"Sorry, word does not contain {usrGuessedWord}");
                        Console.WriteLine();
                        GuessTheWord();
                    }
                    else if (notGuessedCharacters > 0 && tempCount > 0)
                    {
                        Console.WriteLine($"Congrats, you guessed in total {WordToGuess.Length - notGuessedCharacters} characters of the word, " +
                            $"there is a left {notGuessedCharacters} characters:");
                        CheckGuessedWord();
                        Console.WriteLine();
                        if (notGuessedCharacters > 0)
                        {
                            GuessTheWord();
                        }
                    }
                }
            }
        }

    }
}
