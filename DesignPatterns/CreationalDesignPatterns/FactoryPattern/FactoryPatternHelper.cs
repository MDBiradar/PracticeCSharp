using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern.TransportExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    internal static class FactoryPatternHelper
    {
        internal static void TrasnportExample()
        {
            List<ITransport?> transportModes =
            [
                TransportFactory.GetInstance("truck"),
                TransportFactory.GetInstance("Ship"),
                TransportFactory.GetInstance("air"),
            ];
            transportModes.ForEach(tm => Console.WriteLine(tm?.Delivery()));
        }
    }
}
