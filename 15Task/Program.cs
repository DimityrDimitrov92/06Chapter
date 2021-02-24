using System;

namespace _15Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int temp, randomNum;
            Console.Write("Enter n munber : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int [n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach (int i  in array)
            {
                randomNum = rand.Next(0, n);
                temp = array[i];
                array[i] = array[randomNum];
                array[randomNum] = temp;
            }
            foreach (var i in array)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
