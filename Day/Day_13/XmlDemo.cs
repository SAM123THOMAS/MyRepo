using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_13
{
    internal class xmldemos
    {
        public static void Main2()
        {

            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\employeedata.xml");
            Console.WriteLine(reader.Name);
            Console.WriteLine(reader.BaseURI);
            Console.WriteLine(reader.LocalName);
            while (reader.Read())
            {
                if (reader.HasValue)
                {
                    //Console.WriteLine("Name: "+reader.Value);
                    //Console.WriteLine("Node Depth: " + reader.Depth.ToString());
                    Console.WriteLine("Value: " + reader.Value);

                }
            }

        }
    }
}