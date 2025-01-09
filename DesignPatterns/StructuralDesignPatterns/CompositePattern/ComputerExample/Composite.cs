using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.CompositePattern
{
    public class Composite(string name) : IComponent
    {
        private readonly string _name = name;

        public List<IComponent> components = [];

        public void DisplayMessage()
        {
            Console.WriteLine(_name);
            Console.WriteLine("-------------");
            foreach (var child in components)
            {
                child.DisplayMessage();
            }
            Console.WriteLine();
        }

        public void AddComponent(IComponent leaf)
        {
            components.Add(leaf);
        }

    }
}
