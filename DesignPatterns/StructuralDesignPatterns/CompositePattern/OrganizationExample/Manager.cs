using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.StructuralDesignPatterns.CompositePattern.OrganizationExample
{
    internal class Manager(string name, string designation) : IEmployee
    {
        private readonly string _name = name;
        private readonly string _designation = designation;

        List<IEmployee> employees = [];

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }
        
        public void ShowEmployee(int level)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{level} - {_name} Designation: {_designation}" );
                employee.ShowEmployee(level + 2);
            }
        }
    }
}
