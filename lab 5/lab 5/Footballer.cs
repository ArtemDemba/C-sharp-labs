using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
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
}
