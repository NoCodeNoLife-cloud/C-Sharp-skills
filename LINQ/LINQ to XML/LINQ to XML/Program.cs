using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQ_to_XML
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public List<int> Scores;
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create the data source by using a collection initializer.
            // The Student class was defined previously in this topic.
            List<Student> students = new List<Student>()
            {
                new Student {First = "Svetlana", Last = "Omelchenko", ID = 111, Scores = new List<int> {97, 92, 81, 60}},
                new Student {First = "Claire", Last = "O’Donnell", ID = 112, Scores = new List<int> {75, 84, 91, 39}},
                new Student {First = "Sven", Last = "Mortensen", ID = 113, Scores = new List<int> {88, 94, 65, 91}},
            };

            // Create the query.
            var studentsToXML = new XElement("Root",
                from student in students
                let scores = string.Join(",", student.Scores)
                select new XElement("student",
                    new XElement("First", student.First),
                    new XElement("Last", student.Last),
                    new XElement("Scores", scores)
                ) // end "student"
            ); // end "Root"

            studentsToXML.Save("./save.xml");
        }
    }
}