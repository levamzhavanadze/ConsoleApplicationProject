using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApplicationProject
{
    internal class AppMenu
    {

        public void Menu()
        {
            Console.WriteLine("Please select application by entering sequence number: " +
                "\n\t1. Calculator" +
                "\n\t2. Guess The Number" +
                "\n\t3. " +
                "\n\t4. " +
                "\n\t5. " +
                "\n\t6. Exit"
                );
            try
            {
                Validators validators = new Validators();
                var userInput = validators.ValidateUserInputOnEmptyString();
                var userMenuSelection = validators.ParseUserInputToInt(userInput);

                if (userMenuSelection == 1)
                {
                    CalculatorUI calculator = new CalculatorUI();
                    calculator.UserUI();
                    MenuHelper();

                }
                else if (userMenuSelection == 2)
                {
                }
                else if (userMenuSelection == 3)
                {
                }
                else if (userMenuSelection == 4)
                {
                }
                else if (userMenuSelection == 5)
                {
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


        public void MenuHelper()
        {
            Console.WriteLine("Thank you, you have been returned to main menu, please select next action.");
            Menu();
        }
    }
}
