using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_group
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var groupByLastNamesQuery =
                from student in Student.students
                group student by student.LastName into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in groupByLastNamesQuery)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
        }
    }
}