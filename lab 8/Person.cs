using System;
using System.Collections;
namespace lab_8
{
    class Person : BankAccount, ICloneable
    {
        protected int _age;
        protected string _name, _lastName;
        private void CheckName(string Name)
        {
            try
            {
                if (Name.Length > 20)
                {
                    throw new Exception("Name lenght cant be > 20 letters");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception! {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            this.Name = "";
        }
        private void CheckLastName(string LastName)
        {
            try
            {
                if (LastName.Length > 20)
                {
                    throw new Exception("Surname lenght cant be > 20 letters");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception! {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            this.LastName = "";
        }
        private void CheckAge(int value)
        {
            try
            {
                if (value <= 0)
                {
                    throw new Exception($"Age must be positive. Your input: {value}");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public Person()
        {
            _name = "";
            _lastName = "";
        }
        public Person(int Age)
        {
            CheckAge(Age);
        }
        public Person(string Name)
        {
            _name = Name;
            CheckName(Name);
        }
        public Person(string Name, int Age)
        {
            CheckAge(Age);
            _name = Name;
            CheckName(Name);
        }
        public Person(string Name, string LastName)
        {
            _name = Name;
            _lastName = LastName;
            CheckName(Name);
            CheckLastName(LastName);
        }
        public Person(int Age, string Name, string LastName)
        {
            _name = Name;
            _lastName = LastName;
            CheckAge(Age);
            CheckName(Name);
            CheckLastName(LastName);
        }
        public int Age
        {
            get { return _age; }
            set 
            {
                CheckAge(value);
            }
        }
        public string Name
        {
            get { return _name; }
            set
            { 
                _name = value;
                CheckName(Name);
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                _lastName = value;
                CheckLastName(value);
            }
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
            Console.WriteLine($"Current balance: {_sum}");
            Console.WriteLine();
        }
    }
}