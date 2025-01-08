using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.Mobile
{
    internal class PhoneBuilder
    {
        private string? _brand;
        private string? _model;
        private string? _os;
        private decimal _price;

        public string Brand
        {            
            set { _brand = value; }            
        }
        public string Model
        {
            set { _model = value; }
        }

        public string Os
        {
            set { _os = value; }
        }
        public decimal Price
        {
            set { _price = value; }
        }

        public Phone getPhone()
        {
            return new Phone(this._brand , this._model, this._os, this._price);
        }
    }
}
