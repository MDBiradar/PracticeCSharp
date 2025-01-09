using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.BehaviouralDesignPatterns.ObserverPattern.ChannelSubcriptionExample
{
    internal class ObserverPatternHelper
    {
        public static void SubcribeChannelExample()
        {            
            //Channel created
            Channel channel =  new();

            //Subscribers created
            Subscriber s1 = new("Mallikarjun");
            Subscriber s2 = new("Usha");
            Subscriber s3 = new("Manju");
            Subscriber s4 = new("Mahesh");

            //Subscribers subscribed to channel
            channel.Subscribe(s1);
            channel.Subscribe(s2);
            channel.Subscribe(s3);
            channel.Subscribe(s4);

            //Subscribers unsubscribed from channel
            channel.UnSubscribe(s3);

            //Channel uploaded video
            channel.Upload("MBrdr Channel");

        }
    }
}
