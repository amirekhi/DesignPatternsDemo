using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Creational
{
  public class AppSetting
    {
        private static AppSetting? _instance;
        private static readonly object _lock = new object();

        private Dictionary<string, object> _settings = new Dictionary<string, object>();


        private AppSetting()
        {
            // Load settings from a configuration file or environment variables
        }

        public void Set(string key, object value)
        {
            _settings[key] = value;
        }

        public object? Get(string key)
        {
            _settings.TryGetValue(key, out var value);
            return value;
        }

        public static AppSetting Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppSetting();
                    }
                    return _instance;
                }
            }
        }
    }
}