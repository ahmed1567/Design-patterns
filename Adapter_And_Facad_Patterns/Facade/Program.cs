using FacadePattern;

Amplifier amp = new Amplifier();
DvD dvd = new DvD();
Lights lights = new Lights();
Screen screen = new Screen();
Popper popper = new Popper();
Projector projector = new Projector();

Console.WriteLine("Get ready to watch a movie");

popper.On();
popper.Pop();
lights.Dim(10);
screen.Down();
projector.On();
projector.WideScreenMode();
amp.On();
amp.SetDvd();
amp.SetSurroundSound();
amp.SetVolume(5);
dvd.On();
dvd.Play("Anaconda (1997)");

Console.WriteLine("Shutting movie theater down");

popper.Off();
lights.On();
screen.Up();
projector.Off();
amp.Off();
dvd.Stop();
dvd.Off();


// using Facade Pattern

MovieTheaterFacade Facade = new MovieTheaterFacade( amp , dvd , lights , screen , popper , projector );

Facade.WatchMovie("Amistad (1997) ");
Facade.EndMovie();  