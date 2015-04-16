using System;
using System.Collections.Generic;
using System.Globalization;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class TestString
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            decimal price = Convert.ToDecimal("5.345345");
            if (price - Math.Round(price) == 0)
            {
                if (price == 0)
                {
                    Console.WriteLine("&euro;{0}", "0");
                    return;
                }

                Console.WriteLine(string.Format("&euro;{0}", price.ToString("####")));
                return;
            }
            Console.WriteLine("hits");
            string s = price.ToString(CultureInfo.InvariantCulture);
            Console.WriteLine(s);
        }

        [Test]
        public void Boxing_TestedBehavior_ExpectedResult()
        {
//            var myObjects = new Shape {Sides = 10};
//            object o = myObjects;
//            ((Shape) o).Sides = 213;

//            Console.WriteLine(myObjects.Sides);
        }

        public class Shape
        {
            public virtual int Sides
            {
                get { return 0; }
            }
        }

        public class Triangle : Shape
        {
            public override int Sides
            {
                get { return 3; }
            }
        }

        [Test]
        public void MethodUnderTest_TestedBehavior_shapes()
        {
            var shapes = new List<Shape> {new Triangle()};

          //  var sides = circle.Sides;
            foreach (var shape in shapes)
            {
                Console.WriteLine(((Shape)shape).Sides);
            }
        }

        [Test]
        public void oublefslash_TestedBehavior_ExpectedResult()
        {
            var replace = "//www.three.ie/hjk/huihi.com".Replace("//", "");
            Console.WriteLine(replace);
        }
    }
}