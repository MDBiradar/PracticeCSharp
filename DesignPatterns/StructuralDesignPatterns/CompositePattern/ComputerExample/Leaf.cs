using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.CompositePattern
{
    public class Leaf(string name, decimal price) : IComponent
    {
        private string _name = name;
        private decimal _price = price;
       
        public void DisplayMessage()
        {
            Console.WriteLine($"{this._name} : {this._price}");
        }
    }
}
