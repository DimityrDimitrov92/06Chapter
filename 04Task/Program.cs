using System;
using System.Text;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Encoding uTF8 = Encoding.UTF8;
            for (int i = 1; i <= 13; i++)
            {
                
                if (i == 1)
                {
                    Console.WriteLine($"A♠");
                    continue;
                }
                if (i == 11)
                {
                    Console.WriteLine($"J♠");
                    continue;
                }
                if (i == 12)
                {
                    Console.WriteLine($"Q♠");
                    continue;
                }
                if (i==13)
                {
                    Console.WriteLine($"K♠");
                    continue;
                }
                Console.WriteLine($"{i}♠");
            }
            
            for (int j = 1; j <= 13; j++)
            {
                Console.SetCursorPosition(20,j-1);
                if (j == 1)
                {
                    Console.WriteLine($"A♥");
                    continue;
                }
                if (j == 11)
                {
                    Console.WriteLine($"J♥");
                    continue;
                }
                if (j == 12)
                {
                    //a = "Q♥";
                    Console.WriteLine($"Q♥");
                    continue;
                }
                if (j == 13)
                {
                    Console.WriteLine($"K♥");
                    continue;
                }
                Console.WriteLine($"{j}♥");
            }
            for (int k = 1; k <= 13; k++)
            {
                Console.SetCursorPosition(40, k - 1);
                if (k == 1)
                {
                    Console.WriteLine($"A♦");
                    continue;
                }
                if (k == 11)
                {
                    Console.WriteLine($"J♦");
                    continue;
                }
                if (k == 12)
                {
                    //a = "Q♥";
                    Console.WriteLine($"Q♦");
                    continue;
                }
                if (k == 13)
                {
                    Console.WriteLine($"K♦");
                    continue;
                }
                Console.WriteLine($"{k}♦");
            }
            for (int o = 1; o <= 13; o++)
            {
                Console.SetCursorPosition(60, o - 1);
                if (o == 1)
                {
                    Console.WriteLine($"A♣");
                    continue;
                }
                if (o == 11)
                {
                    Console.WriteLine($"J♣");
                    continue;
                }
                if (o == 12)
                {
                    //a = "Q♥";
                    Console.WriteLine($"Q♣");
                    continue;
                }
                if (o == 13)
                {
                    Console.WriteLine($"K♣");
                    continue;
                }
                Console.WriteLine($"{o}♣");
            }

        }
    }
}
