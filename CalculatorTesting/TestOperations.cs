using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CalculatorTesting
{
    [TestClass]
    public class TestOperations
    {
        [TestMethod]
        public void TestAddOperation()
        {
            // Arrange
            CaclulatorDemo.Form1 calc = new CaclulatorDemo.Form1();
            calc.setTextBoxContent("1+5");
            
            // Act
            calc.PerformCalculation(CaclulatorDemo.Form1.Operation.Add);
            System.Windows.Forms.TextBox txtDisplay = calc.getTextBox();

            // Assert
            Assert.AreEqual("6", txtDisplay.Text);
        }
        
        [TestMethod]
        public void TestMultiplyOperation()
        {
            // Arrange
            CaclulatorDemo.Form1 calc = new CaclulatorDemo.Form1();
            calc.setTextBoxContent("10*3");
            
            // Act
            calc.PerformCalculation(CaclulatorDemo.Form1.Operation.Mul);
            System.Windows.Forms.TextBox txtDisplay = calc.getTextBox();

            // Assert
            Assert.AreEqual("30", txtDisplay.Text);
        }
        
        [TestMethod]
        public void TestDivideOperation()
        {
            // Arrange
            CaclulatorDemo.Form1 calc = new CaclulatorDemo.Form1();
            calc.setTextBoxContent("6/2");
            
            // Act
            calc.PerformCalculation(CaclulatorDemo.Form1.Operation.Div);
            System.Windows.Forms.TextBox txtDisplay = calc.getTextBox();

            // Assert
            Assert.AreEqual("3", txtDisplay.Text);
        }
        
        [TestMethod]
        public void TestDivide0Operation()
        {
            // Arrange
            CaclulatorDemo.Form1 calc = new CaclulatorDemo.Form1();
            calc.setTextBoxContent("6/0");
            
            // Act
            calc.PerformCalculation(CaclulatorDemo.Form1.Operation.Div);
            System.Windows.Forms.TextBox txtDisplay = calc.getTextBox();

            // Assert
            Assert.AreEqual("Err", txtDisplay.Text);
        }



        [TestMethod]
        public void TestForPrivateMethod()
        {
            CaclulatorDemo.Form1 calc = new CaclulatorDemo.Form1();

            PrivateObject obj = new PrivateObject(calc);
            var res = obj.Invoke("test");

            Assert.AreEqual(3, res);

        }


    }
}
