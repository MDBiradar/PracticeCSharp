using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.Mobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern;
using PracticeCSharp.DesignPatterns.StructuralDesignPatterns.AdaptorPattern;
using PracticeCSharp.DesignPatterns.StructuralDesignPatterns.CompositePattern;
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
            CreationalDesignPatterns();
            StructuralDesignPatterns();
        }

        private static void StructuralDesignPatterns()
        {
            Console.WriteLine("  Structural Design Patterns");
            Console.WriteLine("============================== ");
            AdaptorPatternHelper.LoggerExample();
            CompositePatternHelper.ComputerAssambleExample();
            Console.WriteLine();
        }

        private static void CreationalDesignPatterns()
        {
            Console.WriteLine("  Creational Design Patterns");
            Console.WriteLine("============================== ");
            FactoryPatternHelper.TrasnportExample();
            Console.WriteLine();

            BuilderPatternHelper.HouseConstuctionExample();
            Console.WriteLine();
            BuilderPatternHelper.ManufactureCarsExample();
            Console.WriteLine();
            BuilderPatternHelper.BuyMobileExample();
            Console.WriteLine();
        }
    }
}
