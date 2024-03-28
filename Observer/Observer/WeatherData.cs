using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherData:ISubject
    {
        private int temp;
        private int humedity;
        private int pressure;

        public int gettemp() { return temp; }
        public int gethumedity() { return humedity; }
        public int getpressure() { return pressure; }

        private List<IObserver> Observers = new();

        public void RegisterObservers(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObservers(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(this,observer);
            }
        }


        public void SetMeasurments(int Temp ,  int Humedity , int pressure)
        {
            this.temp = Temp;
            this.humedity = Humedity; 
            this.pressure = pressure;
            MeasurementsChange();  
        }

        public void MeasurementsChange()
        {
            NotifyObservers();
        }


    }
}
