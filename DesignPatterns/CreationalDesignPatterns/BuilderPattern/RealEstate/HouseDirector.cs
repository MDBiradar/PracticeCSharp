using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate
{
    internal class HouseDirector(IHouseBuilder houseBuilder)
    {
        private readonly IHouseBuilder _houseBuilder = houseBuilder;

        public void BuildSimpleHouse()
        {
            _houseBuilder.BuildRooms(4);
        }

        public void BuildLuxuryHouse()
        {
            _houseBuilder.BuildRooms(10);
            _houseBuilder.BuilGarden();
            _houseBuilder.BuildSwimmingPool();
        }

        public House GetHouse()
        {
            return _houseBuilder.GetHouse();
        }

    }
}
