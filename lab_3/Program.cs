using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class People
    {
        private Person[] data;
        public People()
        {
            data = new Person[10];
        }
        public People(int amount)
        {
            data = new Person[amount];
        }
        public Person this [int index]          //indexer
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
    class Person
    {
        private int _age, _height, _id;
        private string _name, _lastName;
        private static int count = 0;
        public Person()
        {
            _age = _height = 0;
            _name = _lastName = "\0";
            count++;
            _id = count;                    //id of this object
        }
        public Person(int Age, string Name, string LastName, int Height)
        {
            _age = Age;
            _name = Name;
            _lastName = LastName;
            _height = Height;
            count++;
            _id = count;
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int Age)
        {
            _age = Age;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string Name)
        {
            _name = Name;
        }
        public string GetLastName()
        {
            return _lastName;
        }
        public void SetLastName(string LastName)
        {
            _lastName = LastName;
        }
        public int GetHeight()
        {
            return _height;
        }
        public void SetHeight(int Height)
        {
            _height = Height;
        }
        public int GetId()                  //getting ID
        {
            return _id;
        }               
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"LastName: {_lastName}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People(2);
            p[0] = new Person(15, "Валентин", "Зайкин", 40);
            p[1] = new Person(12, "Артём", "Дембовский", 87);
            for (int i = 0; i < 2; i++)
            {
                p[i].PrintInfo();
            }
        }
    }
}
