using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Creational
{
    public interface ICloneable<T>
    {
        T Clone();
    }

    public class Person : ICloneable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public Person Clone()
        {
            return new Person(Name, Age, Address.Clone());
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public class Address : ICloneable<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }

        public Address Clone()
        {
            return new Address(Street, City);
        }

        public Address ShallowCopy()
        {
            return (Address)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Street: {Street}, City: {City}";
        }
    }
}