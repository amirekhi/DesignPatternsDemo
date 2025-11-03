using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Creational
{

    public interface IUserBuilder{
        IUserBuilder SetFirstName(string firstName);
        IUserBuilder SetLastName(string lastName);
        IUserBuilder SetAge(int age);
        IUserBuilder SetEmail(string email);
        IUserBuilder SetActive(bool active);
        User Build();
    }
    public class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string Email { get; }
        public bool IsActive { get; }

        internal User(string firstName, string lastName, int age, string email, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            IsActive = isActive;
        }
    }

    public class UserBuilder : IUserBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _email;
        private bool _isActive;

        public IUserBuilder SetFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public IUserBuilder SetLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public IUserBuilder SetAge(int age)
        {
            _age = age;
            return this;
        }

        public IUserBuilder SetEmail(string email)
        {
            _email = email;
            return this;
        }

        public IUserBuilder SetActive(bool active)
        {
            _isActive = active;
            return this;
        }

        public User Build()
        {
            // You can add validation logic here
            if (string.IsNullOrEmpty(_firstName))
                throw new InvalidOperationException("First name is required.");

            return new User(_firstName, _lastName, _age, _email, _isActive);
        }
    }

}