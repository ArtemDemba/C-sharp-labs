using System;
using System.Text;
namespace English_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            Console.WriteLine("Input string: ");
            temp = Console.ReadLine();
            StringBuilder str = new StringBuilder(temp);
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] < 97 || str[j] > 122)        //checking that all letters are english
                {
                    Console.WriteLine("Not all letters from the Endlish alphabet!");
                    return;
                }
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'
                    || str[i] == 'y')
                {
                    if (str[i + 1] == 'z')
                    {
                        str[i + 1] = 'a';       //'z' change to 'a'
                    }
                    else
                    {
                        str[i + 1]++;           //replacing a letter with the next alphabetically
                    }
                }
            }
            Console.WriteLine(str);
        }
    }
}

