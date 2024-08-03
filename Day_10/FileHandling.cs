using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    internal class FileHandling
    {
        public static void Main3()
        {
            String FilePath = @"D:\Samplefile.txt";

            // FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            //FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            //byte[] bdata = Encoding.Default.GetBytes("Hello I am Sam");
            //fileStream.Write(bdata, 0, bdata.Length);
            FileStream fileStream= new FileStream(FilePath,FileMode.Open,FileAccess.Read);
            string data;

            using (StreamReader sr = new StreamReader(fileStream))
            {
                data = sr.ReadToEnd();
            }
             Console.WriteLine(data);
            fileStream.Close();
        }
    }
}
