using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Xml;
using ConsoleApplicationProject.MenuAndHelpers;

namespace ConsoleApplicationProject.GuessTheNumbers
{
    /// <summary>
    /// This class is responsible for guessing number game, where user is asked to guess randomly generated number within the user defined range.
    /// </summary>
    public class GuessTheNumber : Validators
    {
        public void GuessNumber()
        {
            Random random = new Random();

            Console.WriteLine($"Please enter any number from {int.MinValue + 1} to {int.MaxValue} to generate random number.");

            Console.WriteLine("Please enter Min Number:");
            //define min value for random method
            int usrMinValue = AskUserToEnterInt();
            //define max value for random method
            Console.WriteLine("Please enter Max Number:");
            int usrMxnValue = AskUserToEnterInt();

            while (usrMinValue > usrMxnValue)
            {
                Console.WriteLine($"Max Number should be greater then Min Number. You entered Min Number = {usrMinValue} and Max Number = {usrMxnValue}");
                usrMxnValue = AskUserToEnterInt();
            }
            //generate random number
            var numberToGuess = random.Next(usrMinValue, usrMxnValue);

            Console.WriteLine($"I generated random number between {usrMinValue} and {usrMxnValue}, can you guess the number:");

            //asking user to guess number. Using the validators on entered input.
            int usrGuessedNumber = AskUserToEnterInt();

            //Loop where user will be trapped until the number is guessed
            while (usrGuessedNumber != numberToGuess)
            {
                if (numberToGuess > usrGuessedNumber)
                {
                    Console.WriteLine($"Generated number is higher then {usrGuessedNumber}");

                    //asking user to enter number again if previous number is lower than target
                    usrGuessedNumber = AskUserToEnterInt();
                }
                else if (numberToGuess < usrGuessedNumber)
                {
                    Console.WriteLine($"Generated number is lower then {usrGuessedNumber}");

                    //asking user to enter number again if previous number is higher than target
                    usrGuessedNumber = AskUserToEnterInt();
                }
                if (numberToGuess == usrGuessedNumber)
                {
                    //congrats user if number is guessed
                    Console.WriteLine($"Congratulation, you guessed the number {numberToGuess}");
                }
            }

        }
    }
}