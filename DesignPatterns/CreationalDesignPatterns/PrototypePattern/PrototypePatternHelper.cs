using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.PrototypePattern
{
    internal class PrototypePatternHelper
    {
        public static void PrototypeCarExample()
        {
            Console.WriteLine("Before change:");
            PrototypeCar car1 = new("Civic", "Red", "Honda");
            car1.ShowDetails("car1");
            PrototypeCar car2 = (PrototypeCar)car1.Clone();
            Console.WriteLine();
            Console.WriteLine("After car2 cloned from car1");
            car2.ShowDetails("car2");
            Console.WriteLine();
            Console.WriteLine("After car1 changes:");
            car1.Color = "Blue";
            car1.Company = "Hyundai";
            car1.Model = "i20";
            car1.ShowDetails("car1");
            car2.ShowDetails("car2");
        }
    }
}
