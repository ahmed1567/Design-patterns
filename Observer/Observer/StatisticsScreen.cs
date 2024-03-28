using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StatisticsScreen : IObserver, IDisplay
    {
        private int temp;
        private int humedity;
        private int pressure;

        public ISubject WeatherData { get; set; }

        public StatisticsScreen( ISubject subject)
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
            Console.WriteLine($"Temp state : {temp / 2} %");
            Console.WriteLine($"Humedity state : {humedity / 2} %");
            Console.WriteLine($"Pressure state : {pressure / 2} %");
        }
    }
}
