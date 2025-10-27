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


// AppSetting appsetting = AppSetting.Instance;
// appsetting.Set("Setting1", "Value1");

// AppSetting appSetting2 = AppSetting.Instance;
// appSetting2.Set("Setting2", 42);

// Console.WriteLine(appsetting.Get("Setting1"));
// Console.WriteLine(appSetting2.Get("Setting2"));
// //appsetting has access to the same instance thats why we can see changes from appsetting2 from line 9
// Console.WriteLine(appsetting.Get("Setting2"));