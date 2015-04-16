using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public sealed class Singleton
    {
        public sealed class Catalogue
        {
            public List<string> Products { get; set; }
            public int Id { get; set; }

            public Catalogue()
            {
                Products = new List<string> {"Nexus", "Samsung", "Iphone"};
                Id = GetHashCode();
            }
        }
        private Singleton()
        {
        }

        private static Catalogue _instance;
        private static readonly object _padlock = new object();

        
        public static Catalogue Instance
        {
            get
            {
                lock (_padlock)
                {
                    return _instance ?? (_instance = new Catalogue());
                }
            }
        }
    }

    public class TestSingleton
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            Console.WriteLine(Singleton.Instance.Id);

            foreach (var product in Singleton.Instance.Products)
            {
                Console.WriteLine(product);
            }
        }

        [Test]
        public void DoThread()
        {
            Task.Run(() => Console.WriteLine(Singleton.Instance.Id)).Wait(TimeSpan.FromSeconds(1));
            Task.Run(() => Console.WriteLine(Singleton.Instance.Id)).Wait(TimeSpan.FromSeconds(1));

            Task.WaitAll();
        }
    }
}