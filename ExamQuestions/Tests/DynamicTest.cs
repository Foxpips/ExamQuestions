using System.Web.UI.WebControls;
using System.Xml;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class DynamicTest
    {
        [Test]
        public void Dynamic_TestedBehavior_ExpectedResult()
        {
            var ec = new ExampleClass();
            // The following call to exampleMethod1 causes a compiler error  
            // if exampleMethod1 has only one parameter. Uncomment the line 
            // to see the error. 
            //ec.exampleMethod1(10, 4);

            dynamic dynamicEc = new ExampleClass();
            // The following line is not identified as an error by the 
            // compiler, but it causes a run-time exception.
            dynamicEc.exampleMethod1(10);
            

            // The following calls also do not cause compiler errors, whether  
            // appropriate methods exist or not.
            dynamicEc.someMethod("some argument", 7, null);
            dynamicEc.nonexistentMethod();

            dynamic doc = new XmlDocument();
            var baz = doc.foo.qux;

        }
    }

    public class ExampleClass
    {
        public ExampleClass() { }
        public ExampleClass(int v) { }

        public void exampleMethod1(int i) { }

        public void exampleMethod2(string str) { }
        public void someMethod(string str,int k,object o) { }
    }
}