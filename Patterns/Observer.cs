using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public interface IObserver
    {
        void Update();
    }

    public class Sheet : IObserver
    {
        private DataSource data;
        public Sheet(DataSource dataSource)
        {
            data = dataSource;
            data.Attach(this);
        }
        public void Update()
        {
            Console.WriteLine("Sheet updated");
        }
    }
    public class Chart : IObserver
    {
        private DataSource data;
        public Chart(DataSource dataSource)
        {
            data = dataSource;
            data.Attach(this);
        }
        public void Update()
        {
            Console.WriteLine("Chart updated");
        }

        public List<int> ?Data
        {
            get { return data?.Data; }
        }
    }

    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    public class DataSource : Subject
    {
        private List<int> ?data;

        public List<int> ?Data
        {
            get { return data; }
            set
            {
                data = value;
                Notify();
            }
        }
    }
}