using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public decimal Result { get; set; }
        public decimal Number { get; set; }

        public Calculator() { }
        public Calculator(decimal number) : this()
        {
            Number = number;
        }
    }
}
