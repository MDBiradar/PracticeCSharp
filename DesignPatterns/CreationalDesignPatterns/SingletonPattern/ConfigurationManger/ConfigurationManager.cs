using System;
using System.Collections.Generic;

namespace PracticeCSharp.DesignPatterns.CreationalDesignPatterns.SingletonPattern.ConfigurationMangaer
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager? _instance = null;
        private static readonly object _lock = new();
        private Dictionary<string, string> _configurations;

        private ConfigurationManager()
        {
            _configurations = new Dictionary<string, string>()
            {
                { "DBConnectionString", "MySQL" },
                { "Timeout", "30" }
            };
        }
        public static ConfigurationManager? Instance
        {
            get
            {
                lock(_lock)
                {
                    return _instance ??= new ConfigurationManager();
                }                
            }
        }

        public string GetConfiguration(string key)
        {
            return _configurations[key];
        }

        public void SetConfiguration(string key, string value)
        {
            if (_configurations.ContainsKey(key))
                _configurations[key] = value;
            else
                _configurations.Add(key, value);
        }    
    }
}
