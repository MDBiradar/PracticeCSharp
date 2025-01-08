using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate
{
    internal class ConcreteHouseBuilder : IHouseBuilder
    {
        private readonly House _house = new();
        public void BuildRooms(int rooms)
        {
            _house.rooms = rooms;
        }

        public void BuildSwimmingPool()
        {
            _house.swimmingPool = true;
        }

        public void BuilGarden()
        {
            _house.garden = true;
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
