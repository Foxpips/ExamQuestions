using System;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public abstract class BaseClass
    {
        protected BaseClass()
        {
            
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Base Class Virtual Version");
        }

        public void NonVirtualMethod()
        {
            Console.WriteLine("Base Class Non Virtual Version\n");
        }

        public abstract void AbstractMethod();
    }

    public class DerivedClass : BaseClass,IAwesome
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("Derived Class Virtual Version");
        }

        public void NonVirtualMethod()
        {
            Console.WriteLine("Derived Class Non Virtual Version\n");
        }

        public  override void AbstractMethod()
        {
            Console.WriteLine("Overridden base class abstract method in derived class");
        }
    }

    public interface IAwesome
    {
    }

    public class TestVirtualVsShadowMethods
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
//            var baseClass = new BaseClass();
            var derivedClass = new DerivedClass();

//            baseClass.VirtualMethod();
//            baseClass.NonVirtualMethod();

            derivedClass.VirtualMethod();
            derivedClass.NonVirtualMethod();

            BaseClass baseClassHoldingDerived = new DerivedClass();

            baseClassHoldingDerived.VirtualMethod();
            baseClassHoldingDerived.NonVirtualMethod();
        }
    }
}