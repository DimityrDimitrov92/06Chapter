using System;

namespace _14Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hex : ");
            string a = Console.ReadLine();
            int Myint = Convert.ToInt32(a, 16);
            Console.WriteLine(Myint);
        }
    }
}
