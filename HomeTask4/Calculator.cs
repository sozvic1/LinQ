using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4
{
    class Calculator
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public static dynamic Subtraction(dynamic a, dynamic b)
        {
            return a - b;
        }
        
        public static dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }
        public static dynamic Divide(dynamic a, dynamic b)
        {if(b!=0)
            return a / b;
            else {return "На ноль делить нельзя"; }
        }

    }
}
