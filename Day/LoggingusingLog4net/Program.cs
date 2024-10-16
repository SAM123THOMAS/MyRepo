﻿using log4net;
using System.Xml.Schema;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace LoggingusingLog4net

{
   
    public class Program1
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main1(string[] args)
        {
            logger.Info("Application is starting");
            logger.Debug("some debug log");
            logger.Warn("Warning logs");
            logger.Error("Error logs");
            logger.Fatal("Fatal logs");
            logger.Info("Application has finished");
        }
    }
}