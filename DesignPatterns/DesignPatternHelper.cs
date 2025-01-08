using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.Mobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate;
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
            //FactoryPattern();
            BuildPattern();
        }

        private static void BuildPattern()
        {
            //HouseConstuction();
            //ManufactureCars();
            BuyMobile();
        }

        private static void BuyMobile()
        {
            Phone phone = new PhoneBuilder() { Brand = "Samsung", Model="Galaxy S24" }.getPhone();
            Console.WriteLine(phone.ToString());
        }

        private static void ManufactureCars()
        {
            ICarBuilder carBuilder = new ConcreteCarBuilder();
            CarDirector carDirector = new(carBuilder);
            carDirector.BuildSportCar();
            Console.WriteLine(carBuilder.GetCar());

            carBuilder = new ConcreteCarBuilder();
            carDirector = new(carBuilder);
            carDirector.BuildNormalCar();
            Console.WriteLine(carBuilder.GetCar());
        }

        private static void HouseConstuction()
        {
            IHouseBuilder houseBuilder = new ConcreteHouseBuilder();
            HouseDirector houseDirector = new(houseBuilder);
            houseDirector.BuildSimpleHouse();
            Console.WriteLine(houseDirector.GetHouse());


            houseBuilder = new ConcreteHouseBuilder();
            houseDirector = new(houseBuilder);
            houseDirector.BuildLuxuryHouse();
            Console.WriteLine(houseDirector.GetHouse());
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
