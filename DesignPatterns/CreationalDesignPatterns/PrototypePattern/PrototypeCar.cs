using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.PrototypePattern
{
    internal class PrototypeCar : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
        public PrototypeCar(string model, string color, string company)
        {
            Model = model;
            Color = color;
            Company = company;
        }       

        public ICar Clone()
        {
            return (ICar)this.MemberwiseClone();
        }

        public void ShowDetails(string car)
        {
            Console.WriteLine($"{car}: Model: {Model}, Color: {Color}, Company: {Company}");
        }
    }
}
