using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Calculator
    {
        public decimal Calculate(decimal v1, decimal v2, string o)
        {
            switch (o)
            {
                case "+":
                    return Sum(v1, v2);
                case "-":
                    return Subtract(v1, v2);
                case "*":
                    return Multiply(v1, v2);
                case "/":
                    return Divide(v1, v2);
                default:
                    throw new Exception("Not a valid operator!");
            }
        }

        public decimal Sum(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public decimal Subtract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }

        public decimal Multiply(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public decimal Divide(decimal value1, decimal value2)
        {
            return value1 / value2;
        }
    }
}
