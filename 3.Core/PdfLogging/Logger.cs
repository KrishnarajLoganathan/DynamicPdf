using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;
using System.IO;

namespace BCG.CD.Dynamic.Core.PdfLogging
{
    public static class Logger
    {
        private static ILog LogMsg { get; set; }

        static Logger()
        {
            //var log4NetConfigDirectory = AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory;
            //var log4NetConfigFilePath = Path.Combine(log4NetConfigDirectory, "log4net.config");

            var log4NetConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(log4NetConfigFilePath));
            
            
        }

        public static void Log(Exception ex)
        {
            try
            {
                LogMsg = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                LogMsg.Error(ex.Message, ex);
                //Logger.Log(ex.Message);
            }
            catch(Exception exp)
            {
                var msg = exp.Message;
            }
        }

        public static void Log(string ex)
        {
            LogMsg.Error(ex);
        }
    }
}
