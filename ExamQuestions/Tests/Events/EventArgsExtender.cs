using System;
using System.Threading;

namespace ExamQuestions.Tests.Events
{
    public static class EventArgsExtender
    {
        public static void Raise<TEventArgs>(this TEventArgs e, Object sender, ref EventHandler<TEventArgs> eventDelegate)
        {
            var temp = Volatile.Read(ref eventDelegate);

            if (temp != null)
            {
                temp(sender, e);
            }
        }
    }
}