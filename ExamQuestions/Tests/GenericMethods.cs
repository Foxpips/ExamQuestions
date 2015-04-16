using System;
using System.Web;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class GenericMethods
    {
        [Test]
        public void SessionTester()
        {
            Console.WriteLine(Entity());
        }

        public static string Entity()
        {
            string entity = "";
            var httpRequest = new HttpRequest("TestFile", "www.testGetter.ie/TestFile.aspx", "");
            var httpContext = new HttpContext(httpRequest, new HttpResponse(new TextMessageWriter()));

            if (httpContext.ApplicationInstance.Session.Count > 0)
            {
                entity = httpContext.ApplicationInstance.Session["EntityCode"].ToString();
            }

            return entity;
        }
    }
}