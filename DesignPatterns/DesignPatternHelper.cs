using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns
{
    internal static class DesignPatternHelper
    {
        public static void Run()
        {
            FactoryPattern();
        }

        private static void FactoryPattern()
        {
            List<ITransport?> transportModes = new List<ITransport?>();
            transportModes.Add(TransportFactory.GetInstance("truck"));
            transportModes.Add(TransportFactory.GetInstance("Ship"));
            transportModes.Add(TransportFactory.GetInstance("air"));
            transportModes.ForEach(tm => Console.WriteLine(tm?.Delivery()));
        }
    }
}
