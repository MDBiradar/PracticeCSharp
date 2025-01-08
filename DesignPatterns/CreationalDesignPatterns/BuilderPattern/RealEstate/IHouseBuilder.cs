using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate
{
    internal interface IHouseBuilder
    {
        void BuildRooms(int rooms);
        void BuilGarden();
        void BuildSwimmingPool();
        House GetHouse();
    }
}
