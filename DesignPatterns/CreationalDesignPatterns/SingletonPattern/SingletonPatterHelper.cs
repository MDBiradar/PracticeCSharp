using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.SingletonPattern.ClockExample;
using PracticeCSharp.DesignPatterns.CreationalDesignPatterns.SingletonPattern.ConfigurationMangaer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.SingletonPattern
{
    internal class SingletonPatterHelper
    {
        internal static void ConfigurationManagerExample()
        {
            Console.WriteLine("Singleton Pattern Example");
            Console.WriteLine("=========================");

            var config1 = ConfigurationManager.Instance;
            var config2 = ConfigurationManager.Instance;

            Console.WriteLine($"Config1 Object : {config1?.GetConfiguration("DBConnectionString")}");
            Console.WriteLine($"Config2 Object : {config1?.GetConfiguration("DBConnectionString")}");
            Console.WriteLine();
            Console.WriteLine("Updating the Config2 Object only");
            Console.WriteLine();
            config2?.SetConfiguration("DBConnectionString", "Oracle");

            Console.WriteLine($"Config1 Object : {config1?.GetConfiguration("DBConnectionString")}");
            Console.WriteLine($"Config2 Object : {config1?.GetConfiguration("DBConnectionString")}");
            Console.WriteLine();
        }
        internal static void ClockExample()
        {
            var time1 = Clock.Instance;
            var time2 = Clock.Instance;

            time1?.SetCurrentTime(DateTime.Now.AddDays(1));
            time2?.SetCurrentTime(DateTime.Now.AddDays(1));

            Console.WriteLine($"Object 1 Time: {time1?.GetCurrentTime()}");
            Console.WriteLine($"Object 2 Time: {time2?.GetCurrentTime()}");
            Console.WriteLine();

            Console.WriteLine("Updated Object 2 time");
            time2?.SetCurrentTime(DateTime.Now);

            Console.WriteLine($"Object 1 Time: {time1?.GetCurrentTime()}");
            Console.WriteLine($"Object 2 Time: {time2?.GetCurrentTime()}");
            Console.WriteLine();
        }
    }
}
