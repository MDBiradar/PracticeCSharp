using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.BuilderPattern.Mobile
{
    internal class Phone
    {
        private string? _brand;
        private string? _model;
        private string? _os;
        private decimal _price;

        public Phone(string? brand, string? model, string? os, decimal price)
        {
            this._brand = brand;
            this._model = model;
            this._os = os;
            this._price = price;
        }
        public override string? ToString()
        {
            return $"Brand: {this._brand}, Model: {this._model}, OS: {this._os}, Price: {this._price}";
        }
    }
}
