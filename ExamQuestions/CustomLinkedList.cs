using System;

namespace ExamQuestions
{
    public class CustomNode<TType>
    {
        public CustomNode<TType> Next { get; set; }
        public TType Value { get; set; }

        public CustomNode(TType value)
        {
            Value = value;
        }
    }

    public class CustomLinkedList<TType>
    {
        private CustomNode<TType> _head;
        private CustomNode<TType> Current { get; set; }

        public CustomLinkedList(CustomNode<TType> head)
        {
            _head = head;
            Current = _head;
        }

        public void Add(CustomNode<TType> node)
        {
            Current.Next = node;
            Current = node;
        }

        public void AddAfter(TType value, CustomNode<TType> newNode)
        {
            IterateListInternally(currentNode =>
            {
                if (currentNode.Value.Equals(value))
                {
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                }
            });
        }

        private void IterateListInternally(Action<CustomNode<TType>> work)
        {
            var currentNode = _head;

            while (currentNode != null)
            {
                work(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void Remove(CustomNode<TType> removeNode)
        {
            if (removeNode.Value.Equals(_head.Value))
            {
                _head = _head.Next;
                return;
            }

            var currentNode = _head.Next;
            CustomNode<TType> previousNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(removeNode.Value))
                {
                    {
                        previousNode.Next = currentNode.Next;
                    }
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void ReverseList()
        {
            CustomNode<TType> previous = null;
            var current = _head;
            while (current != null)
            {
                var nextNode = current.Next;
                current.Next = previous;
                previous = current;
                current = nextNode;
            }
            _head = previous;
        }

        public void Traverse()
        {
            IterateListInternally(node => Console.Write(" " + node.Value));
            Console.WriteLine();
        }
    }
}