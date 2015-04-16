using System;
using System.Collections;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public struct Shape
    {
        public void Draw(int i)
        {
            Console.WriteLine(i);
        }
    }

    public abstract class Machine
    {
        public abstract void Work();

        public int mNumber { get; set; }

        protected virtual void PrintMachineMachineNumber()
        {
            Console.WriteLine("Machine " + mNumber);
        }
    }

    public class Car : Machine
    {
        public override void Work()
        {
            PrintMachineMachineNumber();
        }

        protected override void PrintMachineMachineNumber()
        {
            Console.WriteLine("Car: " + mNumber);
        }
    }

    public class RaceCar : Car
    {
        public RaceCar(int number)
        {
            mNumber = number;
        }

        public override void Work()
        {
            PrintMachineMachineNumber();
        }

        protected override sealed void PrintMachineMachineNumber()
        {
            Console.WriteLine("RaceCar: " + mNumber);
        }
    }

    public class TestAbstract : IEnumerable
    {
        [Test]
        public void Cartest_TestedBehavior_ExpectedResult()
        {
            Machine bugatti = new RaceCar(10);
            ((Car) bugatti).Work();
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }
}