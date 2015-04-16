using System;

using ExamQuestions.Tests.Events;

namespace ExamQuestions
{
    public class Program
    {

//        public int this[int index] { get{} set }

        public static void Main2(string[] args)
        {
            RunEventCode();
        }

        private static void RunEventCode()
        {
            var mailManager = new MailManager();

            var fax = new Fax();

            fax.Listen(mailManager);

            mailManager.SimulateMail(new NewEmailEventArgs {Content = "Hello there", Title = "Hello Simon!"});

            Console.Read();
            Console.WriteLine("Hey buddy whats happening");
        }
    }
}