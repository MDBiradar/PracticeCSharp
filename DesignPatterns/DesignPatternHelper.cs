﻿using PracticeCSharp.DesignPatterns.BehaviouralDesignPatterns.ObserverPattern.ChannelSubcriptionExample;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.AutoMobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.Mobile;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.RealEstate;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.FactoryPattern;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.PrototypePattern;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.SingletonPattern;
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
            //StructuralDesignPatterns();
            //BehaviouralDesignPatterns();
        }

        private static void CreationalDesignPatterns()
        {
            Console.WriteLine("  Creational Design Patterns");
            Console.WriteLine("============================== ");
            //FactoryPatternHelper.TrasnportExample();


            //BuilderPatternHelper.HouseConstuctionExample();           
            //BuilderPatternHelper.ManufactureCarsExample();           
            //BuilderPatternHelper.BuyMobileExample();

            //PrototypePatternHelper.PrototypeCarExample();

            //SingletonPatterHelper.ConfigurationManagerExample();
            SingletonPatterHelper.ClockExample();
        }       

        private static void StructuralDesignPatterns()
        {
            Console.WriteLine("  Structural Design Patterns");
            Console.WriteLine("============================== ");
            AdaptorPatternHelper.LoggerExample();
            CompositePatternHelper.ComputerAssambleExample();
            CompositePatternHelper.OrganizationStructureExample();
            Console.WriteLine();
        }

        private static void BehaviouralDesignPatterns()
        {
            Console.WriteLine("  Behavioural Design Patterns");
            Console.WriteLine("=============================== ");
            ObserverPatternHelper.SubcribeChannelExample();
            Console.WriteLine();
        }

    }
}
