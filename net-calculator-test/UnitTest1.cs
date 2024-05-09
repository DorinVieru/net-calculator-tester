using NUnit.Framework;
using net_calculator_test;
using net_calculator_tester;

namespace net_calculator_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // TEST ADD
        [Test]
        public void TestAdd()
        {
            try
            {
                float expected = 13;
                float actual = Calculator.Add(5, 8);
                Assert.AreEqual(expected, actual, "Addizione fallita. Ricontrolla.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Il test TestAdd per la funzione Add è fallito: {ex.Message}");
            }
        }

        // TEST SUBSTRACT
        [Test]
        public void TestSubtract()
        {
            try
            {
                float expected = 5;
                float actual = Calculator.Subtract(10, 5);
                Assert.AreEqual(expected, actual, "Sottrazione fallita. Ricontrolla.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Il test StesSubstract per la funzione Substract è fallito: {ex.Message}");
            }
        }

        // TEST DIVIDE
        [Test]
        public void TestDivide()
        {
            try
            {
                float expected = 4;
                float actual = Calculator.Divide(40, 10);
                Assert.AreEqual(expected, actual, "Divisione fallita. Ricontrolla.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Il test TestDivide per la funzione Divide è fallito: {ex.Message}");
            }
        }

        // SEST MULTIPLY
        [Test]
        public void TestMultiply()
        {
            try
            {
                float expected = 30;
                float actual = Calculator.Multiply(10, 3);
                Assert.AreEqual(expected, actual, "Moltiplicazione fallita. Ricontrolla.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Il test TestMultiply per la funzione Multiply è fallito: {ex.Message}");
            }
        }
    }
}