using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject
{
    internal class Calculator
    {
        //public decimal _a;
        //public decimal _b;


        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
        public decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }
        public decimal Mult(decimal a, decimal b)
        {
            return a * b;
        }
        public decimal Div(decimal a, decimal b)
        {
            return a / b;
        }

    }
}
