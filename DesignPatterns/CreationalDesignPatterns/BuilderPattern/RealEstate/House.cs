using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate
{
    internal class House
    {
        public int rooms;
        public bool garden;
        public bool swimmingPool;

        public override string? ToString()
        {
            return $"Rooms: {rooms}, Garden: {garden}, Swimming Pool: {swimmingPool}";
        }

    }
}
