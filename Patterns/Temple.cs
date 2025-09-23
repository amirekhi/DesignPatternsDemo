using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public class Temple
    {

    }

    public interface IBeverage
    {
        public void Prepare();
    }


    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Console.WriteLine("Specific Preparing tea...");
            Steer();
            AddingSugur();
        }

        public void Steer()
        {
            Console.WriteLine("tea is getting steeres");
        }

        public void AddingSugur()
        {
            Console.WriteLine("sugur is being added ");
        }
    }

    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            Console.WriteLine("Specific Preparing coffee...");
            AddingFoam();
            AddingMilk();
        }

        public void AddingFoam()
        {
            Console.WriteLine("foam is being added ");
        }

        public void AddingMilk()
        {
            Console.WriteLine("milk is being added ");
        }
    }


    public class BeverageFactory
    {
        private IBeverage _beverage;
        public BeverageFactory(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void Serve()
        {
            HeatUp();
            Pour();
            _beverage.Prepare();
        }

        public void HeatUp()
        {
            Console.WriteLine("Heating up beverage...");
        }

        public void Pour()
        {
            Console.WriteLine("Pouring beverage...");
        }
    }
}