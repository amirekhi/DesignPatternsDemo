// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Creational;

AppSetting appsetting = AppSetting.Instance;
appsetting.Set("Setting1", "Value1");

AppSetting appSetting2 = AppSetting.Instance;
appSetting2.Set("Setting2", 42);

Console.WriteLine(appsetting.Get("Setting1"));
Console.WriteLine(appSetting2.Get("Setting2"));
//appsetting has access to the same instance thats why we can see changes from appsetting2 from line 9
Console.WriteLine(appsetting.Get("Setting2"));