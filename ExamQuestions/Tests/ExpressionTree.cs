using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class ExpressionTree
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            Expression<Func<string, string, bool>> startsWith = (s, s1) => s.StartsWith(s1);

            var type = typeof (SomeClass);
            AssemblyName aName = new AssemblyName("SomeNamespace");
            AssemblyBuilder ab = AppDomain.CurrentDomain.DefineDynamicAssembly(aName, AssemblyBuilderAccess.Run);
            ModuleBuilder mb = ab.DefineDynamicModule(aName.Name);
            TypeBuilder tb = mb.DefineType(type.Name, TypeAttributes.Public, type);
            TypeDescriptor.AddAttributes(type);

            var innerMethod = tb.DefineMethod("SomeName", MethodAttributes.Private);
            startsWith.CompileToMethod(innerMethod);
            
            

            var compile = startsWith.Compile();

            var b = compile("Jon", "Jo");

            Console.WriteLine(b);
        }
    }

    public class SomeClass
    {
    }
}