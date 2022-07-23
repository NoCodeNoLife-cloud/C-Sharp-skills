using System;

namespace struct_function
{
    internal class Program
    {
        private struct Student
        {
            public int ID;
            public string name;

            /// <summary>
            /// struct method
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{nameof(ID)}: {ID}, {nameof(name)}: {name}";
            }
        }

        public static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "陈巧之";
            student.ID = 2022;
            Console.Out.WriteLine($"{student}");
        }
    }
}