using System;
using System.Threading.Tasks;

namespace ExamQuestions.Tests.Events
{
    public class MailManager : IMailManager
    {
        public event EventHandler<NewEmailEventArgs> NewEmailEvent;

        public delegate void MyCustomEventHandler<in TArgs>(object sender, TArgs ags);

        public async Task SimulateMail(NewEmailEventArgs args)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            args.Raise(this, ref NewEmailEvent);
            
            NewEmailEvent.Raise(this, args);
        }
    }
}