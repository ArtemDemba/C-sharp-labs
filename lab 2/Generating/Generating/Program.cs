using System;
using System.Text;
using System.Linq;

namespace Generating
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandLeft = new Random();
            Random RandRight = new Random();
            string str;
            str = Console.ReadLine();
            char[] resultArray = new char[str.Length];      //original array
            char temp;
            int randFirst, randSecond;                      
            for (int i = 0; i < str.Length; i++)            //entering data from the string type into
            {                                               //char array
                resultArray[i] = str[i];
            }
            for (int i = 0; i < str.Length * 5; i++)        //determination of the number of permutations
            {
                randFirst = RandLeft.Next(str.Length);
                randSecond = RandRight.Next(str.Length);
                while (randFirst == randSecond)             //checking, to randFirst and randSecond
                {                                           //arent coincide
                    randSecond = RandRight.Next(str.Length);
                }
                temp = resultArray[randFirst];                //swap
                resultArray[randFirst] = resultArray[randSecond];
                resultArray[randSecond] = temp;
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(resultArray[i]);
            }
        }
    }
}
