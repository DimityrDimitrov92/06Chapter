using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i %(3*7) !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
