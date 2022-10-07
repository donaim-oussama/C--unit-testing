using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CaclulatorDemo.Form1 calc = new CaclulatorDemo.Form1();
            calc.PerformCalculation(CaclulatorDemo.Form1.Operation.Add);

        }
    }
}
