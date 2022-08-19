using System;
using System.IO;
using System.Xml;

namespace save_xml
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create the XmlDocument.  
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5'>" +
                        "<title>Pride And Prejudice</title>" +
                        "</book>");

            // Save the document to a file.  
            doc.Save("../../data.xml");
        }
    }
}