using System;
namespace lab_8
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
            Person p1 = new Person();
            p1.Notification += Display;
            p1.TakeMoney(100);
            p1.PutMoney(200);
            p1.TakeMoney(50);
            p1.Age = -5;
            p1.PrintInfo();
        }
        private static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}