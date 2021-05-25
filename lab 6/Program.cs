using System;
namespace lab_6
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
            Sportsman sp1 = new Sportsman();
            Sportsman sp2 = new Sportsman();
            sp1.SetSalary(1000);
            sp2.SetSalary(2000);
            Console.WriteLine(sp2.CompareTo(sp1));
            Console.WriteLine();

            Person p1 = new Person("Artem", 18);
            Person p2 = (Person)p1.Clone();
            p2.Name = "Alexandr";
            p2.LastName = "Lykashenko";
            p2.Age = 93;
            p1.PrintInfo();
            p2.PrintInfo();
        }
    }
}

