using System;

namespace ExamQuestions.Tests.Events
{
    public class Fax
    {
        public void Listen(MailManager mail)
        {
            mail.NewEmailEvent -= (sender, args) => { };

            mail.NewEmailEvent += (sender, args) =>
            {
                Console.WriteLine("New Email Received:");
                Console.WriteLine("Title: {0}", args.Title);
                Console.WriteLine("Content: {0}", args.Content);
            };

            mail.NewEmailEvent += (sender, args) => Console.WriteLine("1 unread email in your inbox!");
        }
    }
}