using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }

    public class ConcreteMediator : IMediator
    {
        public  Colleague1 _colleague1;
        public Colleague2 _colleague2;

        public ConcreteMediator()
        {
            _colleague1 = new Colleague1(this);
            _colleague2 = new Colleague2(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                _colleague2.DoC();
            }
            else if (ev == "B")
            {
                Console.WriteLine("Mediator reacts on B and triggers following operations:");
                _colleague1.DoB();
            }
        }
    }

    public abstract class Colleague
    {
        protected IMediator _mediator;

       public Colleague(IMediator mediator)
       {
           _mediator = mediator;
       }
    }

    public class Colleague1 : Colleague
    {
        public Colleague1(IMediator mediator) : base(mediator)
        {
            
        }
        public void DoA()
        {
            Console.WriteLine("Colleague1 does A.");
            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Colleague1 does B.");
            _mediator.Notify(this, "B");
        }
    }

    public class Colleague2 : Colleague
    {
        public Colleague2(IMediator mediator) : base(mediator)
        {
            
        }
        public void DoC()
        {
            Console.WriteLine("Colleague2 does C.");
        }
    }
}