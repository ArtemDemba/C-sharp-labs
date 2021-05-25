using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
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
}
