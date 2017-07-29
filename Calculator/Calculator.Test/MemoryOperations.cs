using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class MemoryOperations
    {
        [TestMethod]
        public void MemoryClear()
        {
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.MemoryStore();
            calcCtrl.MemoryClear();
            Assert.AreEqual(0M, calcCtrl.MemoryRecall());
        }

        [TestMethod]
        public void MemoryStore()
        {
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.MemoryStore();
            Assert.AreEqual(1.3M, calcCtrl.MemoryRecall());
        }

        [TestMethod]
        public void MemoryRecall()
        {
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.MemoryStore();
            Assert.AreEqual(1.3M, calcCtrl.MemoryRecall());
        }

        [TestMethod]
        public void MemoryAdd()
        {
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.MemoryStore();
            calcCtrl.MemoryAdd();
            Assert.AreEqual(2.6M, calcCtrl.MemoryRecall());
        }

        [TestMethod]
        public void MemorySubtract()
        {
            CalculatorController calcCtrl = new CalculatorController();
            calcCtrl.UpdateNumber("1.3");
            calcCtrl.MemoryStore();
            calcCtrl.MemorySubtract();
            Assert.AreEqual(0M, calcCtrl.MemoryRecall());
        }
    }
}
