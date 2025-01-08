using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile
{
    internal class CarDirector
    {        
        private readonly ICarBuilder _carBuilder;
        public CarDirector(ICarBuilder carBuilder)
        {
            this._carBuilder = carBuilder;
        }

        public void BuildSportCar() {
            _carBuilder.BuildEngine("V8 Engine"); 
            _carBuilder.BuidSeats("Leather Seats"); 
            _carBuilder.BuildGPS(hasGPS: true); 
        }

        public void BuildNormalCar()
        {
            _carBuilder.BuildEngine("TSI 1.0 Engine");
            _carBuilder.BuidSeats("Fabric Seats");
            _carBuilder.BuildGPS(hasGPS: false);
        }

        public void GetCar()
        {
            this._carBuilder.GetCar();
        }
    }
}
