using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern.TransportExample
{
    internal class Air : ITransport
    {
        public string Delivery()
        {
            return "Deliverd by air in a corgo.";
        }
    }
}
