using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.SingletonPattern.ClockExample
{
    internal sealed class Clock
    {
        private static Clock? _instance = null;
        private static readonly object _lock = new();

        private DateTime? _currentTime;

        public static Clock? Instance
        {
            get
            {
                lock(_lock)
                {
                    return _instance ??= new Clock();
                }
            }
        }   

        public void SetCurrentTime(DateTime? currentTime)
        {
            _currentTime = currentTime;
        }

        public DateTime? GetCurrentTime() 
        {
            return _currentTime;
        }
    }
}
