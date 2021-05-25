using System;
using System.Collections;
namespace lab_6
{
    class Sportsman : Person, ISalary, IComparable
    {
        protected bool _uniform;
        protected string _sportRank;
        private int _salary;
        public Sportsman()
        {
            _uniform = false;
            _sportRank = "";
        }
        public Sportsman(string Name) : base(Name) { }
        public Sportsman(int Age, string Name) : base(Name, Age) { }
        
        public Sportsman(bool Uniform, string SportRank)
        {
            _uniform = Uniform;
            _sportRank = SportRank;
        }
        public string SportsmanRank
        {
            get { return _sportRank; }
            set { _sportRank = value; }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Athlete title: {_sportRank}");
            Console.WriteLine($"Sportsman has got his uniform: {_uniform}");
        }
        public int GetSalary()
        {
            return _salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }

        public int CompareTo(object obj)
        {
            Sportsman sp = (Sportsman)obj;
            if (sp.GetSalary() == _salary)
            {
                return 0;
            }
            else if (sp.GetSalary() < _salary)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
