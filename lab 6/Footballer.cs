using System;
namespace lab_6
{
    class Footballer : Sportsman, ISalary, IPrize
    {
        private string _team;
        private int _salary;
        private Award _awardsFootball;
        private int _prize;
        public Footballer()
        {
            _team = "";
            _salary = 0;
        }
        public Footballer(string Name) : base(Name) { }
        public Footballer(int Age, string Name) : base(Age, Name) { }
        public Footballer(string Name, string Team)
        {
            _name = Name;
            _team = Team;
        }
        public Footballer(string Name, int Age, string Team)
        {
            _name = Name;
            _age = Age;
            _team = Team;            
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
        public int GetPrize()
        {
            return _prize;
        }
        public void SetPrize(int Prize)
        {
            _prize = Prize;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Team: {_team}");
            Console.WriteLine($"Salary: {_salary}$");
            Console.WriteLine($"Prize: {_prize}$");
            Console.WriteLine($"Awards:\tGold: {GoldAwards}\n\tSilver: {SilverAwards}\n\tBronze: {BronzeAwards}");
        }
    }
}
