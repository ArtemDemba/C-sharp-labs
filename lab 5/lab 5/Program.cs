using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    struct Award                                
    {
        private int _gold, _silver, _bronze;
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
        public int Silver
        {
            get { return _silver; }
            set { _silver = value; }
        }
        public int Bronze
        {
            get { return _bronze; }
            set { _bronze = value; }
        }
    }
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
    class Sportsman : Person
    {
        protected bool _uniform;
        protected string _sportRank, _gym;        
        public Sportsman()
        {
            _uniform = false;
            _sportRank = "";
            _gym = "";
        }
        public Sportsman(bool Uniform)
        {
            _uniform = Uniform;
        }
        public Sportsman(bool Uniform, string SportRank)
        {
            _uniform = Uniform;
            _sportRank = SportRank;
        }
        public Sportsman(bool Uniform, string SportRank, string Gym)
        {
            _uniform = Uniform;
            _sportRank = SportRank;
            _gym = Gym;
        }
        public string SportsmanRank
        {
            get { return _sportRank; }
            set { _sportRank = value; }
        }
        public string Gym
        {
            get { return _gym; }
            set { _gym = value; }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Athlete title: {_sportRank}");
            Console.WriteLine($"Train in gym: {_gym}");
            Console.WriteLine($"Sportsman has got his uniform: {_uniform}");
        }
    }
    class Footballer : Sportsman
    {
        private string _team;
        protected int _salary;
        private Award _awardsFootball;
        public Footballer()
        {
            _team = "";
            _salary = 0;
        }
        public Footballer(string Name, string LastName, int Age, string Team, int Salary, bool Uniform, string SportRank, string Gym)
        {
            _name = Name;
            _lastName = LastName;
            _age = Age;
            _team = Team;
            _salary = Salary;
            _uniform = Uniform;
            _sportRank = SportRank;
            _gym = Gym;
        }
        public int GoldAwards
        {
            get { return _awardsFootball.Gold; }
            set { _awardsFootball.Gold = value; }
        }
        public int SilverAwards
        {
            get { return _awardsFootball.Silver; }
            set { _awardsFootball.Silver = value; }
        }
        public int BronzeAwards
        {
            get { return _awardsFootball.Bronze; }
            set { _awardsFootball.Bronze = value; }
        }
        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Team: {_team}");
            Console.WriteLine($"Salary: {_salary}$");
            Console.WriteLine($"Awards:\tGold: {GoldAwards}\n\tSilver: {SilverAwards}\n\tBronze: {BronzeAwards}");
        }
    }
    class Athlet : Sportsman
    {
        private double _bestResult;
        private int _salary;
        private Award _awardsAthletics;
        public Athlet()
        {
            _name = "";
            _lastName = "";
            _age = 0;
            _salary = 0;
            _bestResult = 0;
        }
        public Athlet(string Name, string LastName, int Age, int Salary, double _BestResult)
        {
            _name = Name;
            _lastName = LastName;
            _age = Age;
            _salary = Salary;
            _bestResult = _BestResult;
        }

        public double BestResult
        {
            get { return _bestResult; }
            set { _bestResult = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public int GoldAwards
        {
            get { return _awardsAthletics.Gold; }
            set { _awardsAthletics.Gold = value; }
        }
        public int SilverAwards
        {
            get { return _awardsAthletics.Silver; }
            set { _awardsAthletics.Silver = value; }
        }
        public int BronzeAwards
        {
            get { return _awardsAthletics.Bronze; }
            set { _awardsAthletics.Bronze = value; }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Last name {_lastName}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Salary: {_salary}$");
            Console.WriteLine($"Best result: {_bestResult}");
            Console.WriteLine($"Awards:\tGold: {GoldAwards}\n\tSilver: {SilverAwards}\n\tBronze: {BronzeAwards}");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(18, "Artyom");
            Footballer footballer = new Footballer();
            Athlet athlet = new Athlet();
            person.LastName = "Dembovskiy";
            person.PrintInfo();
            Console.WriteLine();
            footballer.LastName = "Ronaldo";
            footballer.Salary = 100000;
            footballer.PrintInfo();
            Console.WriteLine();
            athlet.LastName = "Bolt";
            athlet.GoldAwards = 5;
            athlet.PrintInfo();
            footballer.GoldAwards = 10;

        }
    }
}

