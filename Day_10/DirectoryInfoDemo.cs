using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    internal class DirectoryInfoDemo
    {
        public static void Main()
        {
            String newPath = @"D:\FileDemo\Sample";
            String newPath2 = @"D:\FileDemo2";
            String newPath3 = @"D:\FileDemo2\TestSub";
            DirectoryInfo f1= new DirectoryInfo(newPath);
            //f1.Create();
            //f1.CreateSubdirectory("TestSub");
            DirectoryInfo d1 = new DirectoryInfo(newPath);
            DirectoryInfo d2 = new DirectoryInfo(newPath2);
            //d1.MoveTo(newPath2);
            DirectoryInfo d3 = new DirectoryInfo(newPath3);
            d3.Delete();    

        }
    }
}
