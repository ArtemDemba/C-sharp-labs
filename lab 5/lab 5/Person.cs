using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Person
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
        public Person(int Age, string Name)
        {
             _age = Age;
             _name = Name;
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
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Last name: {_lastName}");
            Console.WriteLine($"Age: {_age}");
        }
    }
}
