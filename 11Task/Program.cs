using System;

namespace _11Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int a = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2);
            Console.WriteLine(binary);
        }

    }
}
