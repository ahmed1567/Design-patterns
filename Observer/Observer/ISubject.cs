using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        public void RegisterObservers(IObserver observer);
        public void RemoveObservers(IObserver observer);
        public void NotifyObservers();
    }
}
