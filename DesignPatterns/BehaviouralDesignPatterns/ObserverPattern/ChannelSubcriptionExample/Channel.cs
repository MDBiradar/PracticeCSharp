using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.BehaviouralDesignPatterns.ObserverPattern.ChannelSubcriptionExample
{
    internal class Channel : ISubject
    {        
        public string? _title;
        private readonly List<Subscriber> _subscribers = new();

        public void Subscribe(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void UnSubscribe(Subscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }        

        public void NotifySubscribers()
        {
            foreach(var sub in _subscribers)
            {
                sub.Update();
            }
        }
        public void Upload(string title)
        {   
            this._title = title;
            this.NotifySubscribers();
        }

    }
}
