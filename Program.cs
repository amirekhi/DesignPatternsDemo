// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

Light light = new Light();
ICommand command = new LightOnCommand(light);
LightRemote remote = new LightRemote(command);
remote.PressButton();
ICommand command_2 = new LightBlink(light);
remote.SetCommand(command_2);
remote.PressButton();