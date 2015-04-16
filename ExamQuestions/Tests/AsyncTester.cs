using System;
using System.Threading.Tasks;

namespace ExamQuestions.Tests
{
    internal class Program
    {
        public static void Main()
        {
            var demo = new AsyncAwaitDemo();
            demo.DoStuff();

            var readLine = Console.ReadLine();
            while (true)
            {
                var line = Console.ReadLine();

                if (line != null && line.Equals("quit"))
                {
                    break;
                }
            }
        }
    }

    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await LongRunningOperation();
        }

        private static async Task LongRunningOperation()
        {
//            await RunAsyncMethod();
            RunSyncMethod();
        }

        private static void RunSyncMethod()
        {
            int counter2 = 0;

            for (counter2 = 0; counter2 < 1000000000; counter2++)
            {
                counter2++;
            }
            Console.WriteLine("\nFinished " + counter2);
        }

        private static async Task RunAsyncMethod()
        {
            int counter = 0;
            await Task.Run(() =>
            {
                for (counter = 0; counter < 1000000000; counter++)
                {
                    counter++;
                }
            });
            Console.WriteLine("\nFinished " + counter);
        }
    }
}