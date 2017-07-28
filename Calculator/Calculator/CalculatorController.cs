﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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

    public class CalculatorController
    {
        private Calculator calculator { get; set; }
        private decimal? input { get; set; }
        private Signs sign { get; set; }

        public CalculatorController()
        {
            Init();
        }

        private void Init()
        {
            calculator = new Calculator(0);
            calculator.Result = 0;
            input = null;
            sign = Signs.NotSet;
        }

        public void Clear()
        {
            Init();
        }

        public decimal Add()
        {
            SetNumber();

            if (sign == Signs.Add)
            {
                sign = Signs.NotSet;
                return calculator.Result += calculator.Number;
            }
            
            sign = Signs.Add;
            calculator.Result = calculator.Number;
            return calculator.Result;
        }

        public decimal Subtract()
        {
            SetNumber();

            if (sign == Signs.Subtract)
            {
                sign = Signs.NotSet;
                return calculator.Result -= calculator.Number;
            }
            
            sign = Signs.Subtract;
            calculator.Result = calculator.Number;
            return calculator.Result;
        }

        public decimal Multiply()
        {
            SetNumber();

            if (sign == Signs.Multiply)
            {
                sign = Signs.NotSet;
                return calculator.Result *= calculator.Number;
            }

            sign = Signs.Multiply;
            calculator.Result = calculator.Number;
            return calculator.Result;
        }

        public decimal Divide()
        {
            SetNumber();

            if (calculator.Number == 0)
            {
                Clear();
                throw new DivideByZeroException("Cannot divide by zero!");
            }

            if (sign == Signs.Divide)
            {
                sign = Signs.NotSet;
                return calculator.Result /= calculator.Number;
            }

            sign = Signs.Divide;
            calculator.Result = calculator.Number;
            return calculator.Result;
        }

        public void UpdateSign(Signs sign)
        {
            this.sign = sign;
        }

        public decimal Calculate()
        {
            switch(sign)
            {
                case Signs.Add:
                    return Add();
                case Signs.Subtract:
                    return Subtract();
                case Signs.Multiply:
                    return Multiply();
                case Signs.Divide:
                    return Divide();
                default:
                    return input.HasValue ? input.Value : 0;             
            }
        }

        public void SetNumber()
        {
            calculator.Number = input.HasValue ? input.Value : 0;
            input = null;
        }

        public decimal UpdateNumber(string numberString)
        {
            string value = input.HasValue ? input.Value.ToString() : String.Empty;
            input = GetNumber($"{value}{numberString}");
            return input.HasValue ? input.Value : 0;
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
            decimal value = input.HasValue ? input.Value : 0;
            return 0 <= value;
        }

        public void setNumberSign (bool isPositive)
        {
            if (sign == Signs.NotSet)
                calculator.Number = input.HasValue ? input.Value : 0;
            calculator.Number *= isPositive && IsNumberPositive() ? 1 : -1;
        }
    }
}
