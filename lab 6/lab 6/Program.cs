using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    interface IBasicMoney
    {
        int GetSalary();
        void SetSalary(int salary);
    }
    interface IAdditionalMoney
    {
        int GetPrize();
        void SetPrize(int prize);
    }
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
    
        class Sportsman : Person, IBasicMoney, IEnumerable
        {
            protected bool _uniform;
            protected string _sportRank;
            private int _salary;
            public Sportsman()
            {
                _uniform = false;
                _sportRank = "";
            }
        public Sportsman(string name)
        {
            _name = name;
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
    }
        class Footballer : Sportsman
        {
            private string _team;
            protected int _salary;
            private Award _awardsFootball;
            private int _prize;
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

            int GetPrize()
            {
                return _prize;
            }

            void SetPrize(int prize)
            {
                _prize = prize;
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
            //Person person = new Person(18, "Artyom");
            //Footballer footballer = new Footballer();
            //Athlet athlet = new Athlet();
            //person.LastName = "Dembovskiy";
            //person.PrintInfo();
            //Console.WriteLine();
            //footballer.LastName = "Ronaldo";
            //footballer.Salary = 100000;
            //footballer.PrintInfo();
            //Console.WriteLine();
            //athlet.LastName = "Bolt";
            //athlet.GoldAwards = 5;
            //athlet.PrintInfo();
            //footballer.GoldAwards = 10;
            //////////////////////////////////////
            ///
            Sportsman sp1 = new Sportsman(true);
            Sportsman sp2 = new Sportsman(false, "ds", "df");
            Sportsman sp3 = new Sportsman(true, "rgte");
            Sportsman[] sportsmen = { sp1, sp2, sp3 };
            IEnumerator ie = sportsmen.GetEnumerator();
            while(ie.MoveNext())
            {
                Console.WriteLine();
            }
        }
    }
}

