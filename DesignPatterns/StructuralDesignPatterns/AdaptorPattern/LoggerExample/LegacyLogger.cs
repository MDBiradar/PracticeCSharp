﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern.LoggerExample
{
    internal class LegacyLogger : ILegacyLogger
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"Legecy Logger: {message}");
        }
    }
}
