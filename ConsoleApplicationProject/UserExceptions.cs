using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject
{
    /// <summary>
    /// This class is responsible to handle exception of AppMenu Class.
    /// </summary>
    internal class MenuWrongSelection : ApplicationException
    {
        public string _message;
        public MenuWrongSelection()
        {
            _message = "Please select one of the options from menu";
        }

        public override string Message
        {
            get
            {
                return _message;
            }
        }

    }
}
