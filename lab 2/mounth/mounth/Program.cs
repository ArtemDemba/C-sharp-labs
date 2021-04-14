using System;
using System.Globalization;
namespace mounths
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Choose language(english, russian, french, german): ");
            choice = Console.ReadLine();
            if (choice == "english" || choice == "English")
            {
                for (int i = 9; i < 21; i++)
                {
                    DateTime mounths = DateTime.Now.AddMonths(i);   //start from january
                    Console.WriteLine(mounths.ToString("MMMM", CultureInfo.GetCultureInfo("en-GB")));   //output mounths
                }
            }
            else if (choice == "russian" || choice == "Russian")
            {
                for (int i = 9; i < 21; i++)
                {
                    DateTime mounths = DateTime.Now.AddMonths(i);
                    Console.WriteLine(mounths.ToString("MMMM", CultureInfo.GetCultureInfo("ru-RU")));
                }
            }
            else if (choice == "french" || choice == "French")
            {
                for (int i = 9; i < 21; i++)
                {
                    DateTime mounths = DateTime.Now.AddMonths(i);
                    Console.WriteLine(mounths.ToString("MMMM", CultureInfo.GetCultureInfo("fr")));
                }
            }
            else if (choice == "german" || choice == "German")
            {
                for (int i = 9; i < 21; i++)
                {
                    DateTime mounths = DateTime.Now.AddMonths(i);
                    Console.WriteLine(mounths.ToString("MMMM", CultureInfo.GetCultureInfo("de-DE")));
                }
            }
            else
            {
                Console.WriteLine("This language is not provided!");
            }
        }
    }
}
