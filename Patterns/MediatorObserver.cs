using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public class Publisher
    {
        public List<DataChangedEventHandler> Subscribers { get; } = new List<DataChangedEventHandler>();

        public void Subscribe(DataChangedEventHandler subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Unsubscribe(DataChangedEventHandler subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber(this, EventArgs.Empty);
            }
        }
    }

    public delegate void DataChangedEventHandler(object sender, EventArgs e);


    public class Box : Publisher
    {
        public string? Content { get; set; }

        public void ChangeContent(string newContent)
        {
            Content = newContent;
            NotifySubscribers();
        }
    }


    public class Subscriber
    {
        public void OnDataChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Data has changed!");
        }
    }
    public class Subscriber_2
    {
        public void OnDataChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Data has changed! sub 2");
        }
    }

}



