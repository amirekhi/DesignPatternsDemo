// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Creational;
using DesignPatternsDemo.Patterns.Structural;
var addr = new Address("1st Ave", "NY");
var original = new Person("Alice", 30, addr);

var deepClone = original.Clone();
var shallowClone = original.ShallowCopy();

deepClone.Name = "Bob";
deepClone.Address.City = "LA";

shallowClone.Name = "Charlie";
shallowClone.Address.City = "SF";

Console.WriteLine(original);        // Name: Alice, Age: 30
Console.WriteLine(original.Address); // Street: 1st Ave, City: SF
Console.WriteLine(deepClone);       // Name: Bob, Age: 30
Console.WriteLine(deepClone.Address); // Street: 1st Ave, City: LA
Console.WriteLine(shallowClone);    // Name: Charlie, Age: 30
Console.WriteLine(shallowClone.Address); // Street: 1st Ave, City: SF
