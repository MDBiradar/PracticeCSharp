using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile
{
    internal class ConcreteCarBuilder : ICarBuilder
    {
        private readonly Car _car = new();
        public void BuidSeats(string seat)
        {
            this._car.seats = seat;
        }

        public void BuildEngine(string engine)
        {
            this._car.engine = engine;
        }

        public void BuildGPS(bool hasGPS)
        {
            this._car.gps = hasGPS;
        }

        public Car GetCar()
        {
            return this._car;
        }
    }
}
