using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter N: (1<K<N) : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) : ");
            int k = int.Parse(Console.ReadLine());
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            {
                Console.WriteLine(n);
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            Console.WriteLine(k);
            Console.WriteLine($"N/k is : {n/k}");

        }
    }
}
