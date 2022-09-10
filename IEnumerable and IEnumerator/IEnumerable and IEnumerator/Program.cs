using System;
using System.Collections;

namespace IEnumerable_and_IEnumerator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person[] personArray = new Person[3]
            {
                new Person("asd", "qwe"),
                new Person("dfg", "dfg"),
                new Person("tyu", "ghj"),
            };
            People people = new People(personArray);
            foreach (Person item in people)
            {
                Console.WriteLine($"{item.FirstName}·{item.LastName}");
            }

            Console.ReadKey();
        }

        public class Person
        {
            public Person(string f, string l)
            {
                this.FirstName = f;
                this.LastName = l;
            }

            public string LastName { get; set; }
            public string FirstName { get; set; }
        }

        // Collectio of Person objects.This class implements IEnumrable so that
        // it can be used with ForEach syntax.
        public class People : IEnumerable
        {
            private Person[] _people;

            public People(Person[] pArray)
            {
                _people = new Person[pArray.Length];
                for (int i = 0; i < pArray.Length; i++)
                {
                    _people[i] = pArray[i];
                }
            }

            // Implement for the GetEnumrator method
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator) GetEnumerator();
            }

            private IEnumerator GetEnumerator()
            {
                return new PeopleEnum(_people);
            }
        }


        // When you impement IEnumerable,you must also implement IEnumrator
        public class PeopleEnum : IEnumerator
        {
            public Person[] _people;

            // Enumerators are positioned before first element
            // Until the first MoveNext() called
            int position = -1;

            public PeopleEnum(Person[] list)
            {
                _people = list;
            }

            public object Current
            {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            public bool MoveNext()
            {
                position++;
                return position < _people.Length;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}