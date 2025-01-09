using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern.LoggerExample
{
    internal class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"New Logger: {message}");
        }
    }
}
