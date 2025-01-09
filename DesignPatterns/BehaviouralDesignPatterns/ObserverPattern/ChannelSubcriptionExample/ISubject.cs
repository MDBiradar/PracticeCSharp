using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.BehaviouralDesignPatterns.ObserverPattern.ChannelSubcriptionExample
{
    internal interface ISubject
    {
        void Subscribe(Subscriber sub);
        void UnSubscribe(Subscriber sub);
        void NotifySubscribers();

        void Upload(string titile);
    }
}
