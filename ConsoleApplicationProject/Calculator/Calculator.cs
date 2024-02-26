using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject.Calculator
{
    /// <summary>
    /// This class is responsible to get 2 decimal numbers and perform math operation on them and return the expresion as string.
    /// </summary>
    internal class Calculator
    {
        //public decimal _a;
        //public decimal _b;


        public string Sum(decimal a, decimal b)
        {
            return $"{a} + {b} = {a + b}";
        }
        public string Sub(decimal a, decimal b)
        {
            return $"{a} - {b} = {a - b}";
        }
        public string Mult(decimal a, decimal b)
        {
            return $"{a} * {b} = {a * b}";
        }
        public string Div(decimal a, decimal b)
        {
            return $"{a} / {b} = {a / b}";
        }


    }
}
