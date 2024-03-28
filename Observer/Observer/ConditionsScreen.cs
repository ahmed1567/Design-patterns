using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConditionsScreen : IObserver, IDisplay
    {
        private int temp;
        private int humedity;
        private int pressure;

        public ISubject WeatherData { get; set; }

        public ConditionsScreen(ISubject subject)
        {
            this.WeatherData = subject;
            WeatherData.RegisterObservers(this);
        }


        public void Update(ISubject subject, IObserver observer)
        {
            if (subject is WeatherData)
            {
                var weatherData = (WeatherData)subject;
                this.temp = weatherData.gettemp();
                this.humedity = weatherData.gethumedity();
                this.pressure = weatherData.getpressure();
                Display();
            }

        }

        public void Display()
        {
            Console.WriteLine($"Temp : {temp}");
            Console.WriteLine($"Humedity : {humedity}");
            Console.WriteLine($"Pressure : {pressure}");
        }
    }
}
