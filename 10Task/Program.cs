using System;

namespace _10Task
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            if (n < 20)
            {
                for (int k = 1; k <= n; k++)

                {
                   for (int j = k; j <(k + n) - 1; j++)
                    {

                        Console.Write(j);
                    }

                    Console.WriteLine((k + n) - 1);
                }

            }
        }
    }
}


