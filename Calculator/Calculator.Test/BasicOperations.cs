using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class BasicOperations
    {
        [TestMethod]
        public void Add()
        {
            decimal result = 1.3M + 1.8M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.Add();
            calcCtrl.UpdateNumber("1.8");
            calcCtrl.Calculate();
            Assert.AreEqual(result, calcCtrl.GetResult());
        }

        [TestMethod]
        public void Subtract()
        {
            decimal result = 1.3M - 1.8M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.Subtract();
            calcCtrl.UpdateNumber("1.8");
            calcCtrl.Calculate();
            Assert.AreEqual(result, calcCtrl.GetResult());
        }

        [TestMethod]
        public void Multiply()
        {
            decimal result = 1.3M * 1.8M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.Multiply();
            calcCtrl.UpdateNumber("1.8");
            calcCtrl.Calculate();
            Assert.AreEqual(result, calcCtrl.GetResult());
        }

        [TestMethod]
        public void Divide()
        {
            decimal result = 1.3M / 1.8M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.Divide();
            calcCtrl.UpdateNumber("1.8");
            calcCtrl.Calculate();
            Assert.AreEqual(result, calcCtrl.GetResult());
        }

        [TestMethod]
        public void Decimal()
        {
            decimal result = 1.3M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1");
            calcCtrl.UpdateNumber(".");
            calcCtrl.UpdateNumber("3");
            calcCtrl.Add();
            Assert.AreEqual(result, calcCtrl.GetResult());
        }

        [TestMethod]
        public void ChangeSign()
        {
            decimal result = -1.3M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.setNumberSign(!calcCtrl.IsNumberPositive());
            Assert.AreEqual(result, calcCtrl.GetNumber());
        }

        [TestMethod]
        public void Backspace()
        {
            decimal result = 1.3M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.34");
            calcCtrl.Backspace();
            calcCtrl.SetNumber();
            Assert.AreEqual(result, calcCtrl.GetNumber());
        }

        [TestMethod]
        public void ClearEntry()
        {
            decimal result = 0M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.Add();
            calcCtrl.UpdateNumber("1.6");
            calcCtrl.ClearEntry();
            calcCtrl.SetNumber();
            Assert.AreEqual(result, calcCtrl.GetNumber());

        }

        [TestMethod]
        public void Clear()
        {
            decimal result = 0M;
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.Add();
            calcCtrl.UpdateNumber("1.6");
            calcCtrl.Clear();
            calcCtrl.SetNumber();
            Assert.AreEqual(result, calcCtrl.GetResult());
        }
    }
}
