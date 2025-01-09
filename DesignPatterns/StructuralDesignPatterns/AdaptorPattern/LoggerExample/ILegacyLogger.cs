using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern.LoggerExample
{
    internal interface ILegacyLogger
    {
        void WriteMessage(string message);
    }
}
