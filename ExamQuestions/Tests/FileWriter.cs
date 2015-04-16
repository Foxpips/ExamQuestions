using System.IO;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class FileWriter
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_WriteToFile()
        {
            using (
                var streamWriter =
                    new StreamWriter(File.Create(@"C:\CreditChecking\CreditApprovalTesting_OrderOperations.txt")))
            {
                streamWriter.Write("Hello");
            }
        }
    }
}