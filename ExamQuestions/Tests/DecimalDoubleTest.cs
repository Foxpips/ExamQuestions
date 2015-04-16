using System;
using System.Globalization;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class DecimalDoubleTest
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var price = 15.00;
            var round = Math.Round(price);
            var remainder = Math.Abs(round % price);
            string priceFinal = remainder > 0 ? price.ToString("F") : round.ToString(CultureInfo.InvariantCulture);
            Console.WriteLine(priceFinal);
        }
    }
}