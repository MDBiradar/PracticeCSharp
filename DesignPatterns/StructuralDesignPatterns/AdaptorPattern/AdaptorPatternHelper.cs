using PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern.LoggerExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern
{
    internal static class AdaptorPatternHelper
    {
        public static void LoggerExample()
        {
            ILogger newLogger = new Logger();
            newLogger.LogMessage("Test Logging..");

            //LegacyLogger is legacy class can't change and still need to use its functionality
            ILegacyLogger legacyLogger = new LegacyLogger();
            ILogger logger = new LoggerAdaptor(legacyLogger);            
            logger.LogMessage("Test Logging..");
            
        }
    }
}
