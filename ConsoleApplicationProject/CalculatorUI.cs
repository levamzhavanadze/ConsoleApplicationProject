using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplicationProject
{
    internal class CalculatorUI
    {
        public void UserUI()
        {
            Calculator calculator = new Calculator();
            Validators userInput = new Validators();

            Console.WriteLine("Hello, this is calculator, where you can perform following math calculation: + - * /");

            Console.WriteLine("Please enter the 1st number");
            decimal _a = userInput.DecimalUserInputValidation();

            Console.WriteLine("Please enter the 2nd number");
            decimal _b = userInput.DecimalUserInputValidation();

            Console.WriteLine($"Please choose operator for this numbers \n\ta = {_a} \n\tb = {_b} \n\t operator could be one of these: + - * /");
            string usrOperator = userInput.ValidateUserInputOnEmptyString();
            //  char.Parse(usrOperator);

            usrOperator = userInput.CalculatorOperatorValidation(usrOperator);


            if (usrOperator == "+")
            {
                Console.WriteLine(calculator.Sum(_a, _b));
            }
            else if (usrOperator == "-")
            {
                Console.WriteLine(calculator.Sub(_a, _b));
            }
            if (usrOperator == "*")
            {
                Console.WriteLine(calculator.Mult(_a, _b));
            }
            if (usrOperator == "/")
            {
                if (_b == 0)
                {
                    Console.WriteLine($"Can not divide {_a} on {_b}, please enter different 2nd number ");
                    while (_b == 0)
                    {

                        _b = userInput.DecimalUserInputValidation();
                        if (_b == 0)
                        {
                            Console.WriteLine($"you entered {_b} again, please enter different 2nd number");
                        }
                    }
                    Console.WriteLine(calculator.Div(_a, _b));
                }
                else
                {
                    Console.WriteLine(calculator.Div(_a, _b));

                }

            }

        }
    }
}
