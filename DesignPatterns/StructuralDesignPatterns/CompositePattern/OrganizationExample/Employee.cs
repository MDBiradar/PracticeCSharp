using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.CompositePattern.OrganizationExample
{
    internal class Employee(string name, string designation) : IEmployee
    {
        private string _name = name;
        private string _designation = designation;       
        public void ShowEmployee(int level)
        {
            Console.WriteLine($"{level} - {this._designation}: {this._name} ");
        }
    }
}
