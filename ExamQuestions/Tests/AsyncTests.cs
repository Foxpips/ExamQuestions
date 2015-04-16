using System;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class AsyncTests
    {
        [Test]
        public void Run()
        {
            SimulateTask();
            Console.WriteLine("Hello World");


//            Task.Run(() =>
//            {
//                Task.Delay(TimeSpan.FromSeconds(2));
//                Console.WriteLine("Hello Human!");
//            }).Wait();
//
//            Console.WriteLine("Hello World");
            Thread.Sleep(TimeSpan.FromSeconds(1));

            
        }

        public async Task SimulateTask()
        {
            await Task.Delay(TimeSpan.FromSeconds(1)); //Simulate Work

            Console.WriteLine("Hello Human!");
        }

        
    }
}

