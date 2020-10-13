using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            // r=1!+2!+3!+...+1/n
            // n=1*2*...*n
            Console.Write("n=");
            int count = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= count; i++)
            {
                result = result = 1 / i;
            }
            Console.WriteLine($"r={result}");
        }
    }
}
