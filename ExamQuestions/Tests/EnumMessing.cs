using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    [Flags]
    public enum WeekDays : byte
    {
        Monday = 0,
        Tuesday = 1 << 0,
        Wednesday = 1 << 1,
        Thursday = 1 << 2,
        Friday = 2 << 3
    }

    public class EnumMessing
    {
        [Test]
        public void MethodUnderTest_EnumBitFlaggin_ExpectedResult()
        {
            var foo = WeekDays.Friday | WeekDays.Thursday;

            bool x = true;
            bool y = false;
            if (GetXValue() ? GetYValue() : false)
            {
                Console.WriteLine();
            }

            var bar = WeekDays.Monday;
            if ((WeekDays.Friday) == foo)
            {
                Console.WriteLine(WeekDays.Friday);
            }
            Console.WriteLine(foo);

            var i = (int) bar;
            Console.WriteLine(i);
            var value = (int) foo;
            Console.WriteLine(value);

            Console.WriteLine(GetIntBinaryString(i, new char[8]));

            Console.WriteLine(GetIntBinaryString(value, new char[8]));
        }

        private static string GetIntBinaryString(int n, char[] binarySize)
        {
            var i1 = binarySize.Length - 1;
            int i = i1;

            var s = Regex.Split("hello", "");

            string theString = "Some Very Large String Here";
            var array = theString.Split(new[] {','}, 10);

            var list = new List<string>();

            Array.ForEach(theString.ToCharArray(), x =>list.Add(x.ToString(CultureInfo.InvariantCulture)));

            string firstElem = array.First();
            string restOfArray = string.Join(" ", array.Skip(1));

            while (i >= 0)
            {
                if ((n & (1 << (i1 - i))) != 0)
                {
                    binarySize[i] = '1';
                }
                else
                {
                    binarySize[i] = '0';
                }
                i--;
            }
            return new string(binarySize);
        }

        private bool GetYValue()
        {
            return true;
        }

        private bool GetXValue()
        {
            return false;
        }
    }
}