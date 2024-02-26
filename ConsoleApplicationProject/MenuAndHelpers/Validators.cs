using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.MenuAndHelpers
{
    /// <summary>
    /// This class is responsible for reusable validations
    /// </summary>
    public class Validators
    {
        /// <summary>
        /// Method validates if user input is decimal number or not.
        /// </summary>
        /// <returns>Decimal/returns>
        public virtual decimal DecimalUserInputValidation()
        {
            var userInput = Console.ReadLine();
            decimal _a;


            while (decimal.TryParse(userInput, out _a) == false)
            {
                Console.WriteLine("Wrong Input");
                userInput = Console.ReadLine();
            }
            return _a;
        }

        /// <summary>
        /// Method validates if user input is null or only spaces
        /// </summary>
        /// <returns>String</returns>
        public virtual string ValidateUserInputOnEmptyString()
        {
            var userInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userInput) == true)
            {
                Console.WriteLine($"You did not entered any value. Please enter valid input:");
                userInput = Console.ReadLine();
            }
            return userInput;
        }

        /// <summary>
        /// Method is helper method where user is asked to enter intager value to continue process
        /// </summary>
        /// <returns>targetInt</returns>
        public virtual int ParseUserInputToInt(string usrInput)
        {
            var _userInput = usrInput;
            int targetInt = -2147483648;

            //Until user entered value is not integer, user will be in this loop. Exception is default value of variable -2147483648
            while (int.TryParse(_userInput, out targetInt) == false || targetInt == -2147483648)
            {
                Console.WriteLine($"Please enter valid input, you entered: <{_userInput}>");
                _userInput = Console.ReadLine();
            }
            return targetInt;
        }

        /// <summary>
        /// Method validates if user choose correct math operator or not. 
        /// </summary>
        /// <param name="usrOperator"></param>
        /// <returns>String</returns>
        public virtual string CalculatorOperatorValidation(string usrOperator)
        {
            //Check if user entered string is one character or it is some string. If length is more then 1 asking user to enter predefined math operator character
            while (usrOperator.Length != 1)
            {
                Console.WriteLine("Please enter the operator, it can not be the text");
                usrOperator = ValidateUserInputOnEmptyString();
            }

            //Defining user selected operator ASCII number
            var input = (int)char.Parse(usrOperator);

            var wrongOperator = false;
            // Checking if user selected operator is withing predefined options: / = 47; * = 42; - = 45; + = 43
            if (input != 47 && input != 42 && input != 45 && input != 43)
            {
                wrongOperator = true;
            }

            //validate if operator is not from predefine list, asking user to select correct one again and validate it.
            while (wrongOperator == true)
            {
                Console.WriteLine("Wrong operator, please enter correct one: + - * /");
                usrOperator = ValidateUserInputOnEmptyString();
                input = char.Parse(usrOperator);
                if (input != 47 || input != 42 || input != 45 || input != 43)
                {
                    wrongOperator = false;
                }
            }
            return usrOperator;
        }

        /// <summary>
        /// Method is asking user to input Int
        /// </summary>
        /// <returns>Int</returns>
        public virtual int AskUserToEnterInt()
        {
            var usrInput = ValidateUserInputOnEmptyString();
            int parsedInt = ParseUserInputToInt(usrInput);

            return parsedInt;

        }

    }
}
