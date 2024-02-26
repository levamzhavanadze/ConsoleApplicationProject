using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApplicationProject.Calculator;
using ConsoleApplicationProject.GuessTheNumbers;
using ConsoleApplicationProject.Hangman;
using ConsoleApplicationProject.LanguageDictionary;

namespace ConsoleApplicationProject.MenuAndHelpers
{
    /// <summary>
    /// This class represents main entrance point for user into the application, where user can choose needed program.
    /// </summary>
    public class AppMenu : Validators
    {
        /// <summary>
        /// Asking user to choose program
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("Please select application by entering sequence number: " +
                "\n\t1. Calculator" +
                "\n\t2. Guess The Number" +
                "\n\t3. Hangman" +
                "\n\t4. Language Dictionary" +
                "\n\t5. " +
                "\n\t6. Exit"
                );
            //Handle user selection
            try
            {
                var userInput = ValidateUserInputOnEmptyString();
                var userMenuSelection = ParseUserInputToInt(userInput);

                if (userMenuSelection == 1)
                {
                    CalculatorUI calculator = new CalculatorUI();
                    calculator.UserUI();
                    ReturnToMainMenu();

                }
                else if (userMenuSelection == 2)
                {
                    GuessTheNumber guessTheNumber = new GuessTheNumber();
                    guessTheNumber.GuessNumber();
                    ReturnToMainMenu();
                }
                else if (userMenuSelection == 3)
                {
                    HangmanUI hangmanUI = new HangmanUI();
                    hangmanUI.GuessTheWord();
                }
                else if (userMenuSelection == 4)
                {
                    LanguageUI languageUI = new LanguageUI();
                    languageUI.LanguageDictionary();
                }
                else if (userMenuSelection == 5)
                {
                    Console.WriteLine("Sorry, functionality is not ready, try later.");
                }
                else if (userMenuSelection == 6)
                {
                    Console.WriteLine("Thank you for using our Console App.");


                    // Pause the program for 4 seconds
                    Thread.Sleep(2000);

                    // Close the console window
                    Environment.Exit(0);
                }
                else
                {
                    throw new MenuWrongSelection();
                }
            }
            catch (MenuWrongSelection wrongMenuItem)
            {
                Console.WriteLine(wrongMenuItem.Message);
                Menu();
            }
        }

        public void ReturnToMainMenu()
        {
            Console.WriteLine("Thank you, you have been returned to main menu, please select next action.");
            Menu();
        }
    }
}
