using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Creational
{
    // this also could be an abstract class
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    public interface IComponent
    {
        void Paint();
    }


    public interface IButton : IComponent
    {
        void Click();
    }

    public interface ICheckbox : IComponent
    {
        void Check();
    }

    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Windows Button Clicked");
        }

        public void Paint()
        {
            Console.WriteLine("Windows Button Painted");
        }
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Windows Checkbox Checked");
        }

        public void Paint()
        {
            Console.WriteLine("Windows Checkbox Painted");
        }
    }

    public class MacOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacOS Button Clicked");
        }

        public void Paint()
        {
            Console.WriteLine("MacOS Button Painted");
        }
    }

    public class MacOSCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("MacOS Checkbox Checked");
        }

        public void Paint()
        {
            Console.WriteLine("MacOS Checkbox Painted");
        }
    }
    //implementation of abstract factory

    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }

    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }

}