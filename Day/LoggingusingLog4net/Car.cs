using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingusingLog4net
{
    public class car
    {
        public string Model { get; set; }
        public double Year { get; set; }
        public string Owner { get; set; }

        public car(string model, double year, string owner)
        {
            Model = model;
            Year = year;
            Owner = owner;

        }

    }
    internal class Person
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            logger.Info("Application is starting");
        
        }
    }
}
