using System;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    internal struct Point
    {
        private Int32 m_x, m_y;

        public Point(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public void Change(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public override String ToString()
        {
            return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
        }
    }

    public class QuizQuestions
    {
        [Test]
        public void _TestedBehavior_ExpectedResult()
        {
            var strings = new Quiz[10];
            var strings2 = new Quiz[10];

            strings[0] = new Quiz {Name = "Larry"};
//            strings.CopyTo(strings2, 0);

            strings2 = ((Quiz[])strings.Clone());
            Console.WriteLine(strings == strings2);

            strings2[0].Name = "Joe";
            Console.WriteLine(strings[0].Name);
        }

        [Test]
        public void StructComparison_TestedBehavior_ExpectedResult()
        {
            var point = new Point(1, 2);
            var point2 = new Point(1, 2);

            Console.WriteLine(point.Equals(point2));
        }

        [Test]
        public void Struct_TestedBehavior_ExpectedResult()
        {
            var p = new Point(1, 1);
            Console.WriteLine(p);

            p.Change(2, 2);
            Console.WriteLine(p);

            Object o = p;
            Console.WriteLine(o);
            var point = (Point) o;
            point.Change(3, 3);
            Console.WriteLine(point);
        }

        [Test]
        public void Bools_TestedBehavior_ExpectedResult()
        {
            const bool answer = new bool();

            Console.Write(answer);
        }

        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var c1 =
                new
                    MyClass(50, 99);
            var c2 =
                new
                    MyClass(70, 99);
            var c3 =
                new
                    MyClass(50, 99);

            var s1 =
                new
                    MyStruct(50, 99);
            var s2 =
                new
                    MyStruct(70, 99);
            var s3 =
                new
                    MyStruct(50, 99);

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.Equals(c3));

            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
        }
    }

    public class Quiz
    {
        public string Name { get; set; }
    }

    internal class MyClass
    {
        private int PrivA;
        public int PubB;

        public MyClass(int a, int b)
        {
            PrivA = a;
            PubB = b;
        }
    }

    internal struct MyStruct
    {
        private int PrivA;
        public int PubB;

        public MyStruct(int a, int b)
        {
            PrivA = a;
            PubB = b;
        }
    }
}