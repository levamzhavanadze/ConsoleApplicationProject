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


        public string Sum(decimal a, decimal b)
        {
            return $"{a} + {b} = {a+b}";
        }
        public string Sub(decimal a, decimal b)
        {
            return $"{a} - {b} = {a-b}";
        }
        public string Mult(decimal a, decimal b)
        {
            return $"{a} * {b} = {a*b}";
        }
        public string Div(decimal a, decimal b)
        {
            return $"{a} / {b} = {a/b}";
        }
  

    }
}
