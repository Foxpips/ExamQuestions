using System;

namespace ExamQuestions.Tests.Events
{
    public class NewEmailEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}