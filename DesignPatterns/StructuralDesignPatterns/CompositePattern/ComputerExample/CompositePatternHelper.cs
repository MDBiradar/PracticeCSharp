using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.CompositePattern
{
    internal class CompositePatternHelper
    {
        public static void ComputerAssambleExample()
        {
            IComponent kb = new Leaf("Key Board", 500);
            IComponent mouse = new Leaf("Mouse", 1000);
            IComponent hdd = new Leaf("HDD", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 6000);
            IComponent monitor = new Leaf("Monitor", 7000);

            Composite peri = new("Peripherals");
            peri.AddComponent(kb);
            peri.AddComponent(mouse);
            peri.AddComponent(monitor);

            Composite cabinet = new("Cabinet");
            cabinet.AddComponent(hdd);
            cabinet.AddComponent(ram);
            cabinet.AddComponent(cpu);

            Composite computer = new("Computer");
            computer.AddComponent(peri);
            computer.AddComponent(cabinet);

            computer.DisplayMessage();

        }
       

    }
}
