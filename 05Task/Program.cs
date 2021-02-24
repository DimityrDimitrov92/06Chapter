using System;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 1,third = 0; 
            Console.Write("Enter n number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("0\n1");
            for (int i = 0; i <=n; i++)
            {
                third= first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
                



            }
        }
    }
}
