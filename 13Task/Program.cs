using System;

namespace _13Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(a,16));
            //var Number = 15;
            //Console.WriteLine(Convert.ToString(Number, 16));

        }
    }
}
