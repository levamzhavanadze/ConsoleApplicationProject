using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ConsoleApplicationProject.MenuAndHelpers;

namespace ConsoleApplicationProject.Calculator
{
    /// <summary>
    /// This class is responsible for Calculator User interface, where user is asked to enter two different numbers, choose math operation and validate user inputs.
    /// </summary>
    public class CalculatorUI : Validators
    {
        public void UserUI()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Hello, this is calculator, where you can perform following math calculation: + - * /");

            Console.WriteLine("Please enter the 1st number");
            decimal _a = DecimalUserInputValidation();

            Console.WriteLine("Please enter the 2nd number");
            decimal _b = DecimalUserInputValidation();

            Console.WriteLine($"Please choose operator for this numbers \n\ta = {_a} \n\tb = {_b} \n\t operator could be one of these: + - * /");
            string usrOperator = ValidateUserInputOnEmptyString();
            //  char.Parse(usrOperator);

            usrOperator = CalculatorOperatorValidation(usrOperator);


            //Based on operation, invoking the Calculator class corresponding method and printing the result.
            if (usrOperator == "+")
            {
                Console.WriteLine(calculator.Sum(_a, _b));
            }
            else if (usrOperator == "-")
            {
                Console.WriteLine(calculator.Sub(_a, _b));
            }
            else if (usrOperator == "*")
            {
                Console.WriteLine(calculator.Mult(_a, _b));
            }
            //Validate if b number is 0. If so asking user to enter different number and printing result.
            else if (usrOperator == "/")
            {
                if (_b == 0)
                {
                    Console.WriteLine($"Can not divide {_a} on {_b}, please enter different 2nd number ");
                    while (_b == 0)
                    {
                        _b = DecimalUserInputValidation();
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
