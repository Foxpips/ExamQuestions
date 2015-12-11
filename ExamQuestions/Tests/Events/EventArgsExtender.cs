using System;
using System.Threading;

namespace ExamQuestions.Tests.Events
{
    public static class EventArgsExtender
    {
        public static void Raise<TEventArgs>(this TEventArgs e, object sender,
            ref EventHandler<TEventArgs> eventDelegate) where TEventArgs : EventArgs
        {
            var temp = Volatile.Read(ref eventDelegate);

            if (temp != null)
            {
                temp(sender, e);
            }
        }

        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs args)
            where TEventArgs : EventArgs
        {
            var temp = Volatile.Read(ref eventHandler);
            if (temp != null)
            {
                temp(sender, args);
            }
        }
    }
}