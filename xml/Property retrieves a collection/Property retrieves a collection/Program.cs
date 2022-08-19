using System;
using System.Xml;

namespace Property_retrieves_a_collection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5' misc='sale item'>" +
                        "<title>The Handmaid's Tale</title>" +
                        "<price>14.95</price>" +
                        "</book>");

            // Move to an element.
            XmlElement myElement = doc.DocumentElement;

            // Create an attribute collection from the element.
            XmlAttributeCollection attrColl = myElement.Attributes;

            // Show the collection by iterating over it.
            Console.WriteLine("Display all the attributes in the collection...");
            for (int i = 0; i < attrColl.Count; i++)
            {
                Console.Write("{0} = ", attrColl[i].Name);
                Console.Write("{0}", attrColl[i].Value);
                Console.WriteLine();
            }

            // Retrieve a single attribute from the collection; specifically, the
            // attribute with the name "misc".
            XmlAttribute attr = attrColl["misc"];

            // Retrieve the value from that attribute.
            String miscValue = attr.InnerXml;

            Console.WriteLine("Display the attribute information.");
            Console.WriteLine(miscValue);

            doc.LoadXml("<book genre='novel' ISBN='1-861003-78' misc='sale item'>" +
                        "<title>The Handmaid's Tale</title>" +
                        "<price>14.95</price>" +
                        "</book>");

            // Move to an element.
            XmlElement root = doc.DocumentElement;

            // Get an attribute.
            attr = root.GetAttributeNode("ISBN");

            // Display the value of the attribute.
            String attrValue = attr.InnerXml;
            Console.WriteLine(attrValue);
        }
    }
}