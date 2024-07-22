using System;
using System.Runtime.ConstrainedExecution;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int k = 1; k <= N - i; k++)
                {
                    Console.Write(" ");
                }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                
                Console.WriteLine(" ");
            }
        }
    }
}
