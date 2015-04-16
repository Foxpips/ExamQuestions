using System;

using NUnit.Framework;

namespace ExamQuestions.Exam
{
    public struct ValueTypes
    {
        public int _x;
        public int _y;

        public ValueTypes(int y)
        {
            _y = y;
            _x = default(int);
        }

        public void DoSomething()
        {
            
        }
    }

    public class TestStructs
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var val = new ValueTypes(1);
            var val2 = val;
            val2._x = 234;

            Console.WriteLine(val._x);
            Console.WriteLine(val2._x);
        }
    }
}