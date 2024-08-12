using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_13
{
    internal class XmlLoad
    {
        public static void Main4()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string filename = "C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\books.xml";
            xmlDoc.Load(filename);
            xmlDoc.Save(Console.Out);

            Console.WriteLine("\n =============================");

            XmlDocument xmlDoc1 = new XmlDocument();
            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\books.xml");
            xmlDoc1.Load(reader);
            xmlDoc1.Save(Console.Out);

            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\domTest.xml", null);
            writer.Formatting = Formatting.Indented; ;
            //xmlDoc.Save(writer);

            XmlDocumentFragment xoc = xmlDoc.CreateDocumentFragment();
            xoc.InnerXml = "<Record>write some demo sample text</Record>";
            Console.WriteLine(xoc.InnerXml);

            XmlNode root = xmlDoc.DocumentElement;
            root.AppendChild(xoc);
            xmlDoc.Save(writer);

            //XmlNode root1 = xmlDoc.DocumentElement;
            //root1.RemoveAll();
            //xmlDoc.Save(writer);
            XmlNode rootNode = xmlDoc.DocumentElement;
            rootNode.ReplaceChild(rootNode.ChildNodes[0], xoc);    

        }
    }
}