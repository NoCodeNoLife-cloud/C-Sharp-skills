using System;
using System.Xml;

namespace XML_file_reading
{
    internal class Program
    {
        private const String filename = "../../items.xml";

        public static void Main()
        {
            XmlTextReader reader = null;

            try
            {
                // Load the reader with the data file and ignore
                // all white space nodes.  
                reader = new XmlTextReader(filename);
                reader.WhitespaceHandling = WhitespaceHandling.None;

                // Parse the file and display each of the nodes.  
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine("<{0}>", reader.Name);
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            Console.WriteLine("<![CDATA[{0}]]>", reader.Value);
                            break;
                        case XmlNodeType.ProcessingInstruction:
                            Console.WriteLine("<?{0} {1}?>", reader.Name, reader.Value);
                            break;
                        case XmlNodeType.Comment:
                            Console.WriteLine("<!--{0}-->", reader.Value);
                            break;
                        case XmlNodeType.XmlDeclaration:
                            Console.WriteLine("<?xml version='1.0'?>");
                            break;
                        case XmlNodeType.Document:
                            break;
                        case XmlNodeType.DocumentType:
                            Console.WriteLine("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                            break;
                        case XmlNodeType.EntityReference:
                            Console.WriteLine(reader.Name);
                            break;
                        case XmlNodeType.EndElement:
                            Console.WriteLine("</{0}>", reader.Name);
                            break;
                    }
                }
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}