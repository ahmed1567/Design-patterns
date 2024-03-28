using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class MovieTheaterFacade
    {
        public Amplifier amp ;
        public DvD dvd; 
        public Lights lights; 
        public Screen screen; 
        public Popper popper; 
        public Projector projector ;
        public MovieTheaterFacade( Amplifier amplifier , DvD _dvd , Lights _lights , Screen _screen , Popper _popper , Projector _projector)
        {
            amp = amplifier;
            dvd = _dvd;
            lights = _lights;
            screen = _screen;
            projector = _projector;
            popper = _popper;
        }

        public void WatchMovie(String movie)
        {
            Console.WriteLine("Get ready to watch a movie with Facade Pattern");

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
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down using Facade Pattern");

            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Off();

        }
    }
}
