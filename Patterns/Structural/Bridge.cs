using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural
{
    public abstract class RemoteControl
    {
        protected IDevice device;

        protected RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void PowerOn();
        public abstract void PowerOff();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();

        void SetChannel(int channel);

        void VolumeUp();
        void VolumeDown();
    }


    public class Remote : RemoteControl
    {
        public Remote(IDevice device) : base(device)
        {
        }

        public override void PowerOn()
        {
            device.TurnOn();
        }

        public override void PowerOff()
        {
            device.TurnOff();
        }
    }

    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public override void PowerOn()
        {
            device.TurnOn();
        }

        public override void PowerOff()
        {
            device.TurnOff();
        }

        public void SetChannel(int channel)
        {
            device.SetChannel(channel);
        }

        public void VolumeUp()
        {
            device.VolumeUp();
        }

        public void VolumeDown()
        {
            device.VolumeDown();
        }   
    }

    public class LgTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("LG TV is now ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("LG TV is now OFF");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"LG TV channel set to {channel}");
        }

        public void VolumeUp()
        {
            Console.WriteLine("LG TV volume increased");
        }

        public void VolumeDown()
        {
            Console.WriteLine("LG TV volume decreased");
        }
    }
    public class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony TV is now ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony TV is now OFF");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Sony TV channel set to {channel}");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Sony TV volume increased");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Sony TV volume decreased");
        }
    }
}