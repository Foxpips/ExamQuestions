using System.Threading.Tasks;

namespace ExamQuestions.Tests.Events
{
    public interface IMailManager
    {
        Task SimulateMail(NewEmailEventArgs e);
    }
}