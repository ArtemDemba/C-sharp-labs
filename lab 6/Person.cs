using System;
using System.Collections;
namespace lab_6
{
    class Person : ICloneable
    {
        protected int _age;
        protected string _name, _lastName;
        public Person()
        {
            _name = "";
            _lastName = "";
        }
        public Person(int Age)
        {
            _age = Age;
        }
        public Person(string Name)
        {
            _name = Name;
        }
        public Person(string Name, int Age)
        {
            _age = Age;
            _name = Name;
        }
        public Person(string Name, string LastName)
        {
            _name = Name;
            _lastName = LastName;
        }
        public Person(int Age, string Name, string LastName)
        {
            _age = Age;
            _name = Name;
            _lastName = LastName;
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public object Clone()
        {
            return new Person
            {
                Name = Name,
                LastName = LastName,
                Age = Age
            };
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Last name: {_lastName}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine();
        }
    }
}
