using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject
{
    internal class UserExceptions : ApplicationException

    {

        public string _message;


        public UserExceptions()
        {
            _message = "Not Correct Operator";
        }


        //public override string Message
        //{
        //    get
        //    {
        //        CalculatorUI calculatorUI = new CalculatorUI();
                
        //        return ca
        //    }
        //}

    }
}
