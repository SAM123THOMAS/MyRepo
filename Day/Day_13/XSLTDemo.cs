using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace Day_13
{
    internal class XSLTDemo
    {
        public static void Main5()
        {
            XslTransform xslt = new XslTransform();
            xslt.Load("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\XLST\\sample.xsl");
            xslt.Transform("C:\\Users\\Administrator\\Desktop\\DotNetTraining\\Day_13\\books.xml", "file.html");

        }
    }
}