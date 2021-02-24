using System;

namespace _16Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int c,bigger,smaller;
            int nok = 0;
            
            Console.Write("Enter the first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int b = int.Parse(Console.ReadLine());
            smaller = Math.Min(a, b);
            bigger = Math.Max(a, b);
            //c = bigger % smaller;
            //Console.WriteLine(c);
            do
            {
                
                c = bigger % smaller;
                bigger = smaller;
                smaller = c;
            } while (smaller != 0);
            Console.WriteLine($"GCD (a,b) = {bigger}");
            Console.WriteLine($"LCM(a,b) = (a*b) / GCD(a,b) ==  {(a*b) / bigger}" );


        }
    }
}
