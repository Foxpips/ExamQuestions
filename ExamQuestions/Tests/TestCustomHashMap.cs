using System;
using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

namespace ExamQuestions.Tests
{
    public class TestCustomHashMap
    {
        [Test]
        public void CustomHashMap_Add_ContainsAddition()
        {
            var hash = new FixedSizeGenericHashTable<string, string>(20);

            hash.Add("1", "item 1");
            hash.Add("2", "item 2");
            hash.Add("dsfdsdsd", "sadsadsadsad");

            string one = hash.Find("1");
            string two = hash.Find("2");
            string dsfdsdsd = hash.Find("dsfdsdsd");

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(dsfdsdsd);

            hash.Remove("1");
            Console.ReadLine();
        }

        [Test]
        public void Dictionary_TestedBehavior_ExpectedResult()
        {
            var hashtable = new Hashtable
            {
                {1, "Simon"}
            };
            var s = hashtable[1];

            hashtable.Add(2,"Tester");

            Console.WriteLine(s);

            var linkedList = new LinkedList<object>();
        }
    }
}