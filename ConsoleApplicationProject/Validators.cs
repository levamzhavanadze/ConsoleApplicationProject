using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject
{
    internal class Validators
    {
        public decimal DecimalUserInputValidation()
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

        public string ValidateUserInputOnEmptyString()
        {
            var userInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userInput) == true)
            {
                Console.WriteLine($"You did not entered any value. Please enter valid input:");
                userInput = Console.ReadLine();
            }
            return userInput;
        }



        public string CalculatorOperatorValidation(string usrOperator)
        {

            while (usrOperator.Length != 1)
            {
                Console.WriteLine("Please enter the operator, it can not be the text");
                usrOperator = ValidateUserInputOnEmptyString();
            }

            var input = (int)char.Parse(usrOperator);
            var wrongOperator = false;
            // = 47; * = 42; - = 45; + = 43
            if (input != 47 && input != 42 && input != 45 && input != 43 )
            {
                wrongOperator = true;
            }

            while (wrongOperator == true)
            {
                Console.WriteLine("Wrong operator, please enter correct one: + - * /");
                usrOperator = ValidateUserInputOnEmptyString();
                input = (int)char.Parse(usrOperator);
                if (input != 47 || input != 42 || input != 45 || input != 43)
                {
                    wrongOperator = false;
                }
            }
            return usrOperator;
        }

        /// <summary>
        /// Method is helper method where user is asked to enter intager value to continue process
        /// </summary>
        /// <returns>targetInt</returns>
        public int ParseUserInputToInt(string usrInput)
        {
            var _userInput = usrInput;
            int targetInt = -99999999;

            //Until user entered value is not integer, user will be in this loop. Exception is default value of variable -99999999
            while (int.TryParse(_userInput, out targetInt) == false || targetInt == -99999999)
            {
                Console.WriteLine($"Please enter valid input, you entered: <{_userInput}>");
                _userInput = Console.ReadLine();
            }
            return targetInt;
        }

    }
}
