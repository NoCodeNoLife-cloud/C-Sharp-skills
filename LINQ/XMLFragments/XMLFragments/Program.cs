﻿using System.Xml.Linq;
using static System.Console;

namespace XMLFragments
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            XElement xcust =
                new XElement("customers",
                    new XElement("customer",
                        new XAttribute("ID", "A"),
                        new XAttribute("City", "New York"),
                        new XAttribute("Region", "North America"),
                        new XElement("order",
                            new XAttribute("Item", "Widget"),
                            new XAttribute("Price", 100)
                        ),
                        new XElement("order",
                            new XAttribute("Item", "Tire"),
                            new XAttribute("Price", 200)
                        )
                    ),
                    new XElement("customer",
                        new XAttribute("ID", "B"),
                        new XAttribute("City", "Mumbai"),
                        new XAttribute("Region", "Asia"),
                        new XElement("order",
                            new XAttribute("Item", "Oven"),
                            new XAttribute("Price", 501)
                        )
                    )
                );

            string xmlFileName = "../../fragment.xml";
            xcust.Save(xmlFileName);

            XElement xcust2 = XElement.Load(xmlFileName);

            WriteLine("Contents of xcust:");
            WriteLine(xcust);
        }
    }
}