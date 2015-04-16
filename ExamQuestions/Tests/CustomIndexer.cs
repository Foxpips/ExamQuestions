using System;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class CustomIndexer<TType>
    {
        private readonly TType[] _arr = new TType[100];

        public int Size
        {
            get { return _arr.Length; }
        }

        public int GetNextFreeBox()
        {
            if (typeof (TType).IsValueType)
            {
                return Array.FindIndex(_arr, y => y.Equals(default(TType)));
            }
            return Array.FindIndex(_arr, x => x == null);
        }

        public TType this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }
    }

    public class TestCustomIndxer
    {
        [Test]
        public void MethodUnderTest_TestedBehavior_ExpectedResult()
        {
            var customIndexer = new CustomIndexer<YourType>();
            customIndexer[customIndexer.GetNextFreeBox()] = new YourType {Name = "Simon"};
            customIndexer[customIndexer.GetNextFreeBox()] = new YourType {Name = "Simon"};
            customIndexer[customIndexer.GetNextFreeBox()] = new YourType {Name = "Simon"};
            customIndexer[customIndexer.GetNextFreeBox()] = new YourType {Name = "Simon"};

            IterateCollection(customIndexer, item =>
            {
                if (item != null)
                {
                    Console.WriteLine(item.Name);
                }
            });

            var customIndexerValue = new CustomIndexer<int>();
            customIndexerValue[customIndexerValue.GetNextFreeBox()] = 12;

            IterateCollection(customIndexerValue, Console.WriteLine);
        }

        private static void IterateCollection<TType>(CustomIndexer<TType> customIndexer, Action<TType> work)
        {
            for (int i = 0; i < customIndexer.Size; i++)
            {
                var item = customIndexer[i];
                work(item);
            }
        }
    }
}