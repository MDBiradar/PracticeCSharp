using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile
{
    internal class Car
    {
        public string? engine;
        public bool gps;
        public string? seats;
                
        public override string? ToString()
        {
            return $"Engine: {engine} GPS: {gps} Seats:{seats}";
        }
    }
}
