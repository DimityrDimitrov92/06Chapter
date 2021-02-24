using System;

namespace _01Task
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter <n)
            { 
                Console.WriteLine(counter);
                counter++;
            }
            Console.Write("Enter number n1 : ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
