using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardObserver
{
    class Train     //Издатель
    {
        List<IObserver> _observers;
        public string Number { get; private set; }

        public Train(string num)
        {
            _observers = new List<IObserver>();
            Number = num;
        }

        public void Come()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Come(this);
            }
        }
        public void Back()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Back(this);
            }
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
