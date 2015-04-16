using System;

namespace ExamQuestions.Tests
{
    public abstract class AnimalBase
    {
        protected virtual void Speak()
        {
            Console.WriteLine("Noise");
        }

        protected abstract void Drink();
    }

    public class Cat : AnimalBase
    {
        protected override sealed void Speak()
        {
            Console.WriteLine("Meow");
        }

        protected override void Drink()
        {
            Console.WriteLine("Slurps milk noisily");
        }
    }

    public class Tabby : Cat
    {
        protected new void Speak()
        {
            Console.WriteLine("Nyan");
        }
    }
}