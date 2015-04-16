using System;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    internal class Layout
    {
        private readonly string[] _values = new string[100]; // Backing store

        public string this[int number]
        {
            get
            {
                // This is invoked when accessing Layout instances with the [ ].
                if (number >= 0 && number < _values.Length)
                {
                    // Bounds were in range, so return the stored value.
                    return _values[number];
                }
                // Return an error string.
                return "Error";
            }
            set
            {
                // This is invoked when assigning to Layout instances with the [ ].
                if (number >= 0 && number < _values.Length)
                {
                    // Assign to this element slot in the internal array.
                    _values[number] = value;
                }
            }
        }
    }

    public class IndexerTest
    {
        [Test]
        public void Inderzer_TestedBehavior_ExpectedResult()
        {
            var layout = new Layout();

            layout[0] = "Simon";

            Console.WriteLine(layout[0]);
        }
    }
}