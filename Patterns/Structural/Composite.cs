using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural
{

    public interface IItem
    {
        public float GetPrice();
    }


    public class Mouse : IItem
    {
        private float _price = 25.99f;
        public float GetPrice()
        {
            return _price;
        }
    }

    public class Keyboard : IItem
    {
        private float _price = 49.99f;
        public float GetPrice()
        {
            return _price;
        }
    }   

    public class CompBox : IItem
    {
        private List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public float GetPrice()
        {
            return _items.Sum(item => item.GetPrice());
        }
    }
}