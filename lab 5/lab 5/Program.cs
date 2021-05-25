using System;
namespace lab_5
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
   class Program
   { 
        static void Main(string[] args)
        {
            Footballer footballer = new Footballer();
            Athlet athlet = new Athlet();
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

