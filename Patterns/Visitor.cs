using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public interface IVisitor
    {
        void VisitVipCustomer(VipCustomer customer);
        void VisitRegularCustomer(RegularCustomer customer);
    }

    public class EmailCustomers : IVisitor
    {
        public void VisitRegularCustomer(RegularCustomer customer)
        {
            Console.WriteLine("an Email has been sent to a regular client");
        }

        public void VisitVipCustomer(VipCustomer customer)
        {
            Console.WriteLine("an Email has been sent to a Vip client");
        }
    }

    public abstract class Client
    {
        private string? _username;
        private string? _email;

        public Client(string? username, string? email)
        {
            _username = username;
            _email = email;
        }
        public abstract void Execute(IVisitor visitor);
    }

    public class VipCustomer : Client
    {
        public VipCustomer(string? username, string? email) : base(username, email)
        {
        }

        public override void Execute(IVisitor visitor )
        {
            visitor.VisitVipCustomer(this);
        }
    }
    public class RegularCustomer : Client   
    {
        public RegularCustomer(string? username, string? email) : base(username, email)
        {
        }

        public override void Execute(IVisitor visitor)
        {
            visitor.VisitRegularCustomer(this);
        }
    }
}