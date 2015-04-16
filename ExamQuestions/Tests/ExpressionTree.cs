using System;
using System.Linq.Expressions;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class ExpressionTree
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            Expression<Func<string, string, bool>> startsWith = (s, s1) => s.StartsWith(s1);

            var compile = startsWith.Compile();

            var b = compile("Jon", "Jo");

            Console.WriteLine(b);
        }
    }
}