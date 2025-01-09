using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.Mobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern
{
    internal static class BuilderPatternHelper
    {
        internal static void BuyMobileExample()
        {
            Phone phone = new PhoneBuilder() { Brand = "Samsung", Model = "Galaxy S24" }.getPhone();
            Console.WriteLine(phone.ToString());
        }

        internal static void ManufactureCarsExample()
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

        internal static void HouseConstuctionExample()
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
    }
}
