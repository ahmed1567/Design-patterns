// See https://aka.ms/new-console-template for more information
using CommandPattern;

SimpleRemote remote = new SimpleRemote();
Light light = new Light();
LightOnCommand lightOn = new LightOnCommand(light);

remote.setCommand(lightOn);
remote.buttonWasPressed();

Console.WriteLine("----------------------------------------------------------");

LightOffCommand lightOff = new LightOffCommand(light);

remote.setCommand(lightOff);
remote.buttonWasPressed();