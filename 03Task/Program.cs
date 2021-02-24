using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int minValue = 0,maxValue = 0,length;

            Console.Write("Enter n numbers : ");
            length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number : ");
                input = int.Parse(Console.ReadLine());
                if(i == 0) { minValue = maxValue = input;}
                else
                {
                    if(minValue > input) { minValue = input; }
                    if(maxValue < input) { maxValue = input; }
                }
            }
            Console.WriteLine($"MinValue is : {minValue} and MaxValue is : {maxValue}");
        }
        
    }
}
