// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Creational;

//factory implementation is instanciated
IGUIFactory factory = new WindowsFactory();
//now factory creates instances of certain groupe
IButton button = factory.CreateButton();
ICheckbox checkbox = factory.CreateCheckbox();
//testing the created instances
button.Click();
checkbox.Check();



//since we use the abstract factory pattern, we can easily switch between different UI implementations and it is abstract factory cause 1-the instantiation is hidden  2-the client code is decoupled from the concrete classes