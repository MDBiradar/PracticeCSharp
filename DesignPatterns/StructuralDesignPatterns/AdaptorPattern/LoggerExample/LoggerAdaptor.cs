using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern.LoggerExample
{
    internal class LoggerAdaptor : ILogger
    {
        ILegacyLogger _legacyLogger;

        public LoggerAdaptor(ILegacyLogger legacyLogger)
        {
            _legacyLogger = legacyLogger;
        }

        public void LogMessage(string message)
        {
            _legacyLogger.WriteMessage(message);
        }
    }
}
