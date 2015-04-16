using System;
using System.Collections;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class YourType
    {
        // Implementation for your strong type goes here. 

        public String Name { get; set; }

        public YourType()
        {
        }
    }

    public class YourTypeCollection<TType> : CollectionBase
    {
        // Provide the strongly typed members for IList. 
        public TType this[int index]
        {
            get { return (TType)((IList)this)[index]; }
            set { ((IList) this)[index] = value; }
        }

        public int Add(YourType value)
        {
            return ((IList) this).Add(value);
        }

        public bool Contains(YourType value)
        {
            return ((IList) this).Contains(value);
        }

        public void Insert(int index, YourType value)
        {
            ((IList) this).Insert(index, value);
        }

        public void Remove(YourType value)
        {
            ((IList) this).Remove(value);
        }

        public int IndexOf(YourType value)
        {
            return ((IList) this).IndexOf(value);
        }

        // Provide the strongly typed member for ICollection. 

        public void CopyTo(YourType[] array, int index)
        {
            ((ICollection) this).CopyTo(array, index);
        }
    }

    public class TestCollection
    {
        [Test]
        public void CollectionTests_TestedBehavior_ExpectedResult()
        {
            var yourTypeCollection = new YourTypeCollection<YourType>();
            yourTypeCollection[0] = new YourType{Name = "Michael"};


            for (int i = 0; i < yourTypeCollection.Capacity; i++)
            {
                Console.WriteLine(yourTypeCollection[i]);
            }
        }
    }
}