using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    internal class TransportFactory
    {
       public static ITransport? GetInstance(string mode)
       {

            if (mode == null)
                return null;

            if (mode.Equals("truck", StringComparison.OrdinalIgnoreCase))
                return new Truck();
            else if(mode.Equals("ship", StringComparison.OrdinalIgnoreCase))
                return new Ship();
            else if (mode.Equals("air", StringComparison.OrdinalIgnoreCase))
                return new Air();
            else 
                return null;
       }
    }
}
