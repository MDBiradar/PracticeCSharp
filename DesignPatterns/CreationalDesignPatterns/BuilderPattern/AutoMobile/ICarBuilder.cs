using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile
{
    internal interface ICarBuilder
    {
        void BuidSeats(string seat);
        void BuildEngine(string engine);
        void BuildGPS(bool hasGPS);

        Car GetCar();
    }
}
