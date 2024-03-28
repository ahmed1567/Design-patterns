using CommandPattern;


// invokers
RemoteControl remoteControl = new RemoteControl();

// Recivers
Light light = new Light();
garageDoor garageDoor = new garageDoor();
Stereo stereo = new Stereo();
ceilingFan ceilingFan = new ceilingFan();


// Commands

LightOnCommand lightOn = new LightOnCommand(light);
LightOffCommand lightOff = new LightOffCommand(light);

DoorOn doorOn = new DoorOn(garageDoor);
DoorOff doorOff = new DoorOff(garageDoor);

FanOn fanOn = new FanOn(ceilingFan);
FanOff fanOff = new FanOff(ceilingFan);

StereoOn stereoOn = new StereoOn(stereo);
StereoOff stereoOff = new StereoOff(stereo);

//Macro Commands

ICommand[] onCommandsCollection = new ICommand[] { lightOn, fanOn, stereoOn, doorOn };

ICommand[] offCommandsCollection = new ICommand[] { lightOff, fanOff, stereoOff, doorOff };

MacroCommand onCollection = new MacroCommand(onCommandsCollection);
MacroCommand offCollection = new MacroCommand(offCommandsCollection);




Console.WriteLine(remoteControl.ToString());

remoteControl.setCommand(0, lightOn, lightOff);
remoteControl.setCommand(1, doorOn, doorOff);
remoteControl.setCommand(2, fanOn, fanOff);
remoteControl.setCommand(3, stereoOn, stereoOff);
remoteControl.setCommand(4, onCollection, offCollection);




remoteControl.onButtonWasPushed(0);
remoteControl.offButtonWasPushed(0);

remoteControl.onButtonWasPushed(1);
remoteControl.offButtonWasPushed(1);

remoteControl.onButtonWasPushed(2);
remoteControl.offButtonWasPushed(2);

remoteControl.onButtonWasPushed(3);
remoteControl.offButtonWasPushed(3);


Console.WriteLine("------------------------Macro Command on button pushed  ---------------------------");
remoteControl.onButtonWasPushed(4);

Console.WriteLine("------------------------Macro Command off button pushed  ---------------------------");

remoteControl.offButtonWasPushed(4);

Console.WriteLine(remoteControl.ToString());

remoteControl.undoButtonWasPushed();

Console.WriteLine(remoteControl.ToString());





