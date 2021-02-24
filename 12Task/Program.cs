using System;

namespace _12Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter binary number : ");
            //int binaryNumber = int.Parse(Console.ReadLine());
            //int decimalNumber = Convert.ToInt32(binaryNumber.ToString(), 2);
            //Console.WriteLine(decimalNumber);
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");
            Console.ReadKey();

        }
    }
}
