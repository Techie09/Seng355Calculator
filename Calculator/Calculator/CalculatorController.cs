using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorController
    {
        public enum Signs
        {
            NotSet,
            Add,
            Subtract,
            Multiply,
            Divide,
            Equals
        }

        private Calculator calculator { get; set; }
        private Signs sign { get; set; }

        public CalculatorController()
        {
            calculator = new Calculator(0);
            calculator.Result = 0;
            sign = Signs.NotSet;
        }

        public void InsertNumber(decimal number)
        {
            calculator.Number = number;
        }

        public decimal Add(decimal number)
        {
            if (sign == Signs.NotSet)
            {
                sign = Signs.Add;
                return calculator.Result = number;
            }

            calculator.Result += number;
            return GetResult();
        }

        public decimal Subtract(decimal number)
        {
            if (sign == Signs.NotSet)
            {
                sign = Signs.Subtract;
                return calculator.Result = number;
            }

            calculator.Result -= number;
            return GetResult();
        }

        public decimal Multiply(decimal number)
        {
            if (sign == Signs.NotSet)
            {
                sign = Signs.Multiply;
                return calculator.Result = number;
            }

            calculator.Result *= number;
            return GetResult();
        }

        public decimal Divide(decimal number)
        {
            if (number == 0)
                throw new DivideByZeroException("Cannot divide by zero!");

            if (sign == Signs.NotSet)
            {
                sign = Signs.Divide;
                return calculator.Result = number;
            }

            calculator.Result /= number;
            return GetResult();
        }

        public decimal Calculate()
        {
            switch(sign)
            {
                case Signs.Add:
                    return Add(calculator.Number);
                case Signs.Subtract:
                    return Subtract(calculator.Number);
                case Signs.Multiply:
                    return Multiply(calculator.Number);
                case Signs.Divide:
                    return Divide(calculator.Number);
                default:
                    return calculator.Number;             
            }
        }

        public decimal GetResult()
        {
            return calculator.Result;
        }

        public decimal GetNumber()
        {
            return calculator.Number;
        }

        public decimal GetNumber(string numberString)
        {
            decimal number = 0;
            if (!Decimal.TryParse(numberString.Replace("&", String.Empty), out number))
                throw new Exception("Could not parse as a number");
            return number;
        }

        public bool IsNumberPositive()
        {
            return 0 <= calculator.Number;
        }

        public void setNumberSign (bool isPositive)
        {
            calculator.Number *= isPositive && IsNumberPositive() ? 1 : -1;
        }
    }
}
