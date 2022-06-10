using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WallPaper
    {
        List<IObserver> _observers;
        public string Article { get; private set; }

        public WallPaper()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void DelObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NewArticle(string article)
        {
            Article = article;
            foreach(IObserver observer in _observers)
            {
                observer.Notify(article);
            }
        }
    }
}
