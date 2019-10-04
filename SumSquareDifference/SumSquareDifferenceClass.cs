using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    public class SumSquareDifferenceClass
    {
        public SumSquareDifferenceClass()
        {

        }
        public double CalculateSumOfSquaresUsingLoop()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i * i;
            }
            return sum;
        }
        public double CalculateSumOfSquaresUsingFormula()
        {
            return (100*101*201)/6;
        }
        public double CalculateSquareOfSumUsingLoop()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            return sum*sum;
        }
        public double CalculateSquareOfSumUsingFormula()
        {
            return ((100*101)/2)*((100*101)/2);
        }
        public double CalculateSumSquareDifferenceUsingLoops()
        {
            return CalculateSquareOfSumUsingLoop() - CalculateSumOfSquaresUsingLoop();
        }
        public double CalculateSumSquareDifferenceUsingFormulas()
        {
            return CalculateSquareOfSumUsingFormula() - CalculateSumOfSquaresUsingFormula();
        }
        public double CalculateSumSquareDifferenceUsingFormulaForCalculateSumOfSquaresAndLoopForCalculateSquareOfSum()
        {
            return CalculateSquareOfSumUsingLoop() - CalculateSumOfSquaresUsingFormula();
        }
        public double CalculateSumSquareDifferenceUsingLoopForCalculateSumOfSquaresAndFormulaForCalculateSquareOfSum()
        {
            return CalculateSquareOfSumUsingFormula() - CalculateSumOfSquaresUsingLoop();
        }
    }
}
