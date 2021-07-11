using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace LogTesting_app
{
    class Logging
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void LogError(Exception ex)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            
            
                logger.Info("----------------------------------------");
                logger.Info("Date: " + DateTime.Now.ToString());

            

           
                while (ex != null)
                {
                    logger.Info(ex.GetType().FullName);
                 
                    logger.Info("Message :" + ex.Message);
                    logger.Info("StackTrace :" + ex.StackTrace);

                    ex = ex.InnerException;
                }
            
            



        }
    }
}
