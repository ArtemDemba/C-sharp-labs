using System;
namespace lab_8
{
    abstract class BankAccount
    {
        public delegate void Message(string message);
        public event Message Notification;        
        protected int _sum;
        public BankAccount()
        {
            _sum = 0;
        }
        public int Sum
        {
            get { return _sum; }
        }

        public void PutMoney(int Sum)
        {
            _sum += Sum;
            Console.ForegroundColor = ConsoleColor.Green;
            Notification?.Invoke($"The account received {Sum}. Your current balance: {_sum}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void TakeMoney(int Sum)
        {
            if(_sum >= Sum)
            {
                _sum -= Sum;
                Notification?.Invoke($"You take {Sum}. Your current balance: {_sum}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Notification?.Invoke($"Its not enough money! Your balance: {_sum}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
