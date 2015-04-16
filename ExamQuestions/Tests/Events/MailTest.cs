using System;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ExamQuestions.Tests.Events
{
    public class MailTest
    {
        [Test]
        public async void Run()
        {
            var mailServer = new MailManager();
            var fax = new Fax();

            fax.Listen(mailServer);

            Task task = mailServer.SimulateMail(new NewEmailEventArgs
            {
                Content = "This is a new Email",
                Title = "Hello World!"
            });

//            Task.Run(
//                () =>
//                    mailServer.SimulateMail(new NewEmailEventArgs
//                    {
//                        Content = "This is a new Email",
//                        Title = "Hello World!"
//                    }));

            Console.WriteLine("You will receive a mail soon!");

            task.Wait();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}