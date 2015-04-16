using System;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    internal struct StructPage
    {
        public string _text;
    }

    internal class RefPage
    {
        public string _text;
    }

    internal class Demonstration
    {
        [Test]
        public static void Main2()
        {
            var originalPrintedPage = new StructPage {_text = "Original printed text"};

            var copyOfPrintedPage = originalPrintedPage;

            copyOfPrintedPage._text = "Changed printed text";

            Console.WriteLine("originalPrintedPage={0}", originalPrintedPage._text);

            var originalWebPage = new RefPage {_text = "Original web text"};

            var copyOfWebPage = originalWebPage;

            copyOfWebPage._text = "Changed web text";

            Console.WriteLine("originalWebPage={0}", originalWebPage._text);

            copyOfWebPage = new RefPage {_text = "Changed web page again"};

            Console.WriteLine("originalWebPage={0}", originalWebPage._text);
        }
    }
}