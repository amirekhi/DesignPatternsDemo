// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Structural;

AdvancedRemote lgAdvancedRemote = new AdvancedRemote(new LgTV());
lgAdvancedRemote.PowerOn();
lgAdvancedRemote.PowerOff();
AdvancedRemote sonyAdvancedRemote = new AdvancedRemote(new SonyTV());
sonyAdvancedRemote.PowerOn();
sonyAdvancedRemote.PowerOff();
sonyAdvancedRemote.SetChannel(5);
sonyAdvancedRemote.VolumeUp();
sonyAdvancedRemote.VolumeDown();
RemoteControl sonyRemote = new Remote(new SonyTV());
sonyRemote.PowerOn();
sonyRemote.PowerOff();