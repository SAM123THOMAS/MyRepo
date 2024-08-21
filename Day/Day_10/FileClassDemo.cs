using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    internal class FileClassDemo
    {
        public static void Main5()
        {
            String sourceFilePath = @"D:\Samplefile.txt";
            String destFilePath = @"D:\FileDemo\Samplefile.txt";
            String newDestPath = @"D:\FileDemo\SamplefileNew.txt";
            if (File.Exists(sourceFilePath)) 
            {
                File.Copy(sourceFilePath, destFilePath, true);
                File.Delete(destFilePath);
                File.Create(newDestPath);
            }
        }
    }
}
