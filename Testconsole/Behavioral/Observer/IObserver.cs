using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Observer
{
    interface IObserver
    {
        void Notify();
    }

    public class UIController : IObserver
    {
        public void Notify()
        {
            Console.WriteLine(this.GetType().Name + ": Score is changed! Score: " + Game.Instance.Score);
        }
    }

    public class AchievementController : IObserver
    {
        private bool _firstThree = false;
        private bool _firstTen = false;

        public void Notify()
        {
            if (!_firstThree && Game.Instance.Score >= 3)
            {
                Console.WriteLine(this.GetType().Name + ": Achievement 'First 3 points' is reached!");
                _firstThree = true;
            }

            if (!_firstTen && Game.Instance.Score >= 10)
            {
                Console.WriteLine(this.GetType().Name + ": Achievement 'First 10 points' is reached!");
                _firstTen = true;
            }
        }
    }

    //Subject
    class ScoreObserver
    {        
        private List<IObserver> _observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Notify();
            }            
        }
    }
}
