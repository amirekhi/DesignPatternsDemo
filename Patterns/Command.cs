using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public interface ICommand
    {
        void Execute();
    }

    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }

    public class LightBlink : ICommand
    {
        private Light _light;
    
        public LightBlink(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Blink();
        }
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is turned ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is turned OFF");
        }

        public void Blink()
        {
            Console.WriteLine("Light is blinking");
        }
    }

    public class LightRemote
    {
        public ICommand Command { get; set; }

        public LightRemote(ICommand command)
        {
            Command = command;  
        }
        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        public void PressButton()
        {
            Command?.Execute();
        }
    }
}