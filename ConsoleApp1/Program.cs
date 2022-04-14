using System;
using System.Collections.Generic;
using System.Text;

namespace skitala
{
    class Program
    {
        static void Main(string[] args)
        {
            string skiText = "это шифр древней спарты";
            int stolbci = 0, count = 0;
            string[] mass = skiText.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            skiText = null;
            foreach (string r in mass)
                skiText += r;
            char[] rezArray = new char[skiText.Length];
            for (int i = 1; i < skiText.Length; i++)
            {
                if (skiText.Length / i == 4)
                {
                    stolbci = i;
                    break;
                }
            }
            for (int i = 0; i < stolbci; i++)
            {
                int plus = i;

                {
                    for (int j = 0; j < 4; j++)
                    {
                        rezArray[count] += skiText[plus];
                        plus += stolbci;
                        count++;
                    }
                }
            }
            for (int i = 0; i < rezArray.Length; i++)
                Console.Write(rezArray[i]);
            Console.WriteLine();
        }
    }
}
