using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ForcastScreen : IObserver, IDisplay
    {
        private int temp;
        private int humedity;
        private int pressure;

        ISubject WeatherData;

        public ForcastScreen( ISubject subject)
        {
            WeatherData = subject;
            WeatherData.RegisterObservers(this);
        }



        public void Display()
        {
            Console.WriteLine("_______________________HERRE__________________Was_________________________________SomeThing___________________HEHEHEHEHEHEHEGHEH");
        }

        public void Update(ISubject subject, IObserver observer)
        {
           if(subject is WeatherData)
            {
                var weatherData = (WeatherData)subject;
                Display();
                
            }
        }
    }
}
