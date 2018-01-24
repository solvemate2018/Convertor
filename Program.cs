using System;

namespace basic_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertor from decimal to binar");
            Console.Write("Please enter a number:");
            var num = int.Parse(Console.ReadLine());

            for (int i = num; i > 1;)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("1");
                    i /= 2;
                }
                else
                {
                    Console.WriteLine("0");
                    i /= 2;
                }
            }
            Console.WriteLine("1");
        }
    }
}