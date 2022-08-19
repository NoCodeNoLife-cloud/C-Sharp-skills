using System;
using System.Xml;

namespace Creating_a_new_Feature
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.LoadXml("<book xmlns:bk='urn:samples' bk:ISBN='1-861001-57-5'>" +
                        "<title>Pride And Prejudice</title>" +
                        "</book>");
            XmlElement root = doc.DocumentElement;

            // Add a new attribute.
            root.SetAttribute("genre", "urn:samples", "novel");

            Console.WriteLine("Display the modified XML...");
            Console.WriteLine(doc.InnerXml);
        }
    }
}