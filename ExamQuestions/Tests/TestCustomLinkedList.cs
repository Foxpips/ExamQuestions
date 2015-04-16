using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class TestCustomLinkedList
    {
        [Test]
        public void CustomLinkedList_AddRemove_ElementsAddedRemoved()
        {
            var head = new CustomNode<object>(1);
            var customLinkedList = new CustomLinkedList<object>(head);

            var customNode = new CustomNode<object>(2);
            customLinkedList.Add(customNode);
            customLinkedList.Add(new CustomNode<object>(3));

            customLinkedList.Traverse();
            customLinkedList.Remove(head);
            customLinkedList.Traverse();
            customLinkedList.Remove(customNode);
            customLinkedList.Traverse();
            customLinkedList.Add(new CustomNode<object>("four"));
            customLinkedList.Traverse();

            customLinkedList.AddAfter(3,new CustomNode<object>(3.5));

            customLinkedList.Traverse();

            customLinkedList.ReverseList();

            customLinkedList.Traverse();
        }
    }
}