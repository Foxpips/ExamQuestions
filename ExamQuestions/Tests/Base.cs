using System;
using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    // Contravariance
    internal interface IGobbler<in T>
    {
        void Gobble(T t);
    }

    public class TestGoggle
    {
        [Test]
        public void Gobble_TestedBehavior_ExpectedResult()
        {
            Action<Base> b = (target) => Console.WriteLine(target.GetType().Name);
            Action<Derived> d = b;
            d(new Derived());

            var arrayList = new ArrayList {6, new Base()};

            var objects = new List<object>();

            objects.Add(1);
            objects.Add(new Base());
        }
    }

    public class QuadrupedGobbler : Donkey, IGobbler<Donkey>
    {
        public void Gobble(Donkey t)
        {
        }
    }

    public class Donkey
    {
    }

    public class Base
    {
        public virtual void Print()
        {
            Console.WriteLine("I am base");
        }
    }

    public class Derived : Base
    {
        public override void Print()
        {
            Console.WriteLine("I am derived");
        }
    }

    public class TestDerivation
    {
        public void IterateBase(IEnumerable<Base> baseList)
        {
        }

        [Test]
        public void DerivedBase_TestedBehavior_ExpectedResult()
        {
            var bases = new List<Base>();

            IterateBase(new List<Derived>());
        }
    }
}