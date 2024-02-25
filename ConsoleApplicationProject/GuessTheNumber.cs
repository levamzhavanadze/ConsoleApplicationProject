using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Xml;

namespace ConsoleApplicationProject
{
    /// <summary>
    /// This class is responsible for guessing number game, where user is asked to guess randomly generated number within the user defined range.
    /// </summary>
    public class GuessTheNumber

    {
        public void GuessNumber()
        {
            Validators validator = new Validators();
            Random random = new Random();

            Console.WriteLine($"Please enter any number from {int.MinValue + 1} to {int.MaxValue} to generate random number.");

            Console.WriteLine("Please enter Min Number:");
            //define min value for random method
            int usrMinValue = validator.AskUserToEnterInt();
            //define max value for random method
            Console.WriteLine("Please enter Max Number:");
            int usrMxnValue = validator.AskUserToEnterInt();
            
            //generate random number
            var numberToGuess = random.Next(usrMinValue, usrMxnValue);

            Console.WriteLine($"I generated random number between {usrMinValue} and {usrMxnValue}, can you guess the number:");

            //asking user to guess number. Using the validators on entered input.
            int usrGuessedNumber = validator.AskUserToEnterInt();

            //Loop where user will be trapped until the number is guessed
            while (usrGuessedNumber != numberToGuess)
            {
                if (numberToGuess > usrGuessedNumber)
                {
                    Console.WriteLine($"Generated number is higher then {usrGuessedNumber}");
                    usrGuessedNumber = validator.AskUserToEnterInt();
                }
                else if (numberToGuess < usrGuessedNumber)
                {
                    Console.WriteLine($"Generated number is lower then {usrGuessedNumber}");
                    usrGuessedNumber = validator.AskUserToEnterInt();
                }
                if (numberToGuess == usrGuessedNumber)
                {
                    Console.WriteLine($"Congratulation, you guessed the number {numberToGuess}");
                }
            }

        }
    }
}