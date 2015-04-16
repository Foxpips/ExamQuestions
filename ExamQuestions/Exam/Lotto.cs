using System;
using System.Collections.Generic;
using System.Linq;

using ExamQuestions.Tests;

using NUnit.Framework;

namespace ExamQuestions.Exam
{
    public class Lotto
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var day = WeekDays.Friday;

            switch (day)
            {
                case WeekDays.Monday:
                    break;
                case WeekDays.Tuesday:
                    break;
                case WeekDays.Wednesday:
                    break;
                case WeekDays.Thursday:
                    break;
                case WeekDays.Friday:
                    RunLotto();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void RunLotto()
        {
            var lottoNumbers = new int[50];
            var myNumbers = new int[49];
            var random = new Random();

            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                lottoNumbers[i] = i + 1;
            }

            for (int i = 0; i < myNumbers.Length; i++)
            {
                PickUniqueNumbers(myNumbers, lottoNumbers, random, i);
            }

            IOrderedEnumerable<int> orderByDescending = myNumbers.OrderByDescending(x => x);

            foreach (int t in orderByDescending)
            {
                Console.Write(t+" ");
            }
        }

        private static void PickUniqueNumbers(IList<int> myNumbers, IList<int> lottoNumbers, Random random, int i)
        {
            var lottoNumber = lottoNumbers[random.Next(49)];
            if (!myNumbers.Contains(lottoNumber))
            {
                myNumbers[i] = lottoNumber;
            }
            else
            {
                PickUniqueNumbers(myNumbers, lottoNumbers, random, i);
            }
        }
    }
}