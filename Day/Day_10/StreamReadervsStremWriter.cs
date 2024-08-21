using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    internal class StreamReadervsStremWriter
    {
        public static void Main4()
        {
            String FilePath = @"D:\Samplefile.txt";
            //StreamWriter streamWriter = new StreamWriter(FilePath,true);
            //Console.WriteLine("Enter Input");
            //string inputData= Console.ReadLine();
            //streamWriter.WriteLine(inputData);
            //streamWriter.Flush();
            //streamWriter.Close();

            StreamReader strRdr = new StreamReader(FilePath);
            Console.WriteLine("Data in file is as below;");
            strRdr.BaseStream.Seek(0, SeekOrigin.Begin);
            string data= strRdr.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data);
                data = strRdr.ReadLine();
            }

        }
    }
}
