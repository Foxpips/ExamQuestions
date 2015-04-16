using System;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class TryCatchExceptionTests
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            int i = 0;
            Console.WriteLine(++i);

            DateTime.Parse("100/10/1000");

            try
            {
                Console.WriteLine("Outer Try");
                SaveCustomer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Outer Catch");
            }
        }

        private static void SaveCustomer()
        {
            try
            {
                Console.WriteLine("Inner Try");
                throw new ArgumentException("Save Customer Exception");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Inner Catch");
                throw ex;
                throw new ArgumentException("Inner Catch Exception");
            }

            finally
            {
                Console.WriteLine("Inner Finally");
//                throw new ArgumentException("Finally Exception");
            }
        }
    }
}