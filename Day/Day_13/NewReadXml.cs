using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_13
{
    internal class newReadxml
    {
        public static void Main3()
        {
            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\XmlTextWriterTEST.xml", null);
            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\books.xml");
            //reader.MoveToContent();
            //reader.MoveToFirstAttribute();
            //Console.WriteLine("First Attribute value" + reader.Value);
            //Console.WriteLine("First Attributre name" + reader.Name);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    writer.WriteNode(reader, true);
                }
            }
            writer.Close();
        }
    }
}