using System;
using SumSquareDifference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumSquareDifferenceTest
{
    [TestClass]
    public class SumSquareDifferenceTest
    {
        //CalculateSumOfSquaresUsingLoop = 1
        //CalculateSquareOfSumUsingLoop = 2
        //CalculateSumOfSquaresUsingFormula = 3
        //CalculateSquareOfSumUsingFormula = 4
        //CalculateSumSquareDifferenceUsingLoops = 5
        //CalculateSumSquareDifferenceUsingFormulas = 6

        SumSquareDifferenceClass ssd = new SumSquareDifferenceClass();
        [TestMethod]
        public void TestCalculateSumOfSquaresUsingLoop() //Expected Result, 1
        {
            Assert.AreEqual(338350.00, ssd.CalculateSumOfSquaresUsingLoop());
        }
        [TestMethod]
        public void TestCalculateSumOfSquaresUsingFormula() //Expected Result, 3
        {
            Assert.AreEqual(338350.00, ssd.CalculateSumOfSquaresUsingFormula());
        }
        [TestMethod]
        public void TestCalculateSquareOfSumUsingLoop() //Expected Result, 2
        {
            Assert.AreEqual(25502500.00, ssd.CalculateSquareOfSumUsingLoop());
        }
        [TestMethod]
        public void TestCalculateSquareOfSumUsingFormula() //Expected Result, 4
        {
            Assert.AreEqual(25502500.00, ssd.CalculateSquareOfSumUsingFormula());
        }
        [TestMethod]
        public void TestCalculateSumSquareDifferenceUsingLoops() //Expected Result, 5
        {
            Assert.AreEqual(25164150.00, ssd.CalculateSumSquareDifferenceUsingLoops());
        }
        [TestMethod]
        public void TestCalculateSumSquareDifferenceUsingFormulas() //Expected Result, 6
        {
            Assert.AreEqual(25164150.00, ssd.CalculateSumSquareDifferenceUsingFormulas());
        }
        [TestMethod]
        public void TestCalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSum() //Expected Result, 1 AND 2
        {
            Assert.AreEqual(25164150.00, ssd.CalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSum());
        }
        [TestMethod]
        public void TestCalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSum() //Expected Result, 1 AND 4
        {
            Assert.AreEqual(25164150.00, ssd.CalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSum());
        }
        [TestMethod]
        public void TestEqualityOfCalculateSumSquareDifferenceUsingFormulasAndCalculateSumSquareDifferenceUsingLoops() //5, 6
        {
            Assert.AreEqual(ssd.CalculateSumSquareDifferenceUsingFormulas(), ssd.CalculateSumSquareDifferenceUsingLoops());
        }
        [TestMethod]
        public void TestEqualityOfCalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSumANDCalculateSumSquareDifferenceUsingLoops() //(3 AND 2), 5
        {
            Assert.AreEqual(ssd.CalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSum(), ssd.CalculateSumSquareDifferenceUsingLoops());
        }
        [TestMethod]
        public void TestEqualityOfCalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSumANDCalculateSumSquareDifferenceUsingLoops() //(1 AND 4), 5
        {
            Assert.AreEqual(ssd.CalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSum(), ssd.CalculateSumSquareDifferenceUsingLoops());
        }
        [TestMethod]
        public void TestEqualityOfCalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSumANDCalculateSumSquareDifferenceUsingFormulas() //(3 AND 2), 6
        {
            Assert.AreEqual(ssd.CalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSum(), ssd.CalculateSumSquareDifferenceUsingFormulas());
        }
        [TestMethod]
        public void TestEqualityOfCalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSumANDCalculateSumSquareDifferenceUsingFormulas() //(1 AND 4), 6
        {
            Assert.AreEqual(ssd.CalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSum(), ssd.CalculateSumSquareDifferenceUsingFormulas());
        }
    }
}
