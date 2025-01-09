using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern.LoggerExample
{
    public interface ILogger
    {
        void LogMessage(string message);
    }
}
