using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.BehaviouralDesignPatterns.ObserverPattern.ChannelSubcriptionExample
{
    internal class Subscriber(string name) : IObserver
    {
        private readonly string _name = name;       
        public void Update()
        {
            Console.WriteLine($"{this._name} : New Video Uploaded...");
        }
    }
}
