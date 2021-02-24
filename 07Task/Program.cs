using System;

namespace _07Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, k1,fact;
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K : ");
            int k = int.Parse(Console.ReadLine());
            n1 = n;
            k1 = k;
            fact = n1 - k1;
            for (int i = n -1; i >0 ; i--)
            {
                n *= i;
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            for (int i = fact-1 ; i >0; i--)
            {
                fact *= i;
            }
            Console.WriteLine($"N={n} , K={k} ,(n-k)! = {fact} === N!*K!/(N-K)! = {(n * k) / fact}");
        }
    }
}
