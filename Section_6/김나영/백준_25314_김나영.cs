using System;
using System.Runtime.ConstrainedExecution;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i+=4)
            {
                Console.WriteLine("long");
            }
            Console.WriteLine("int");
        }
    }
}
