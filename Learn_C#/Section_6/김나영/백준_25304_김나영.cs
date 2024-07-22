using System;
using System.Runtime.ConstrainedExecution;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int num=0;

            for (int i = 1; i <= N; i++)
            {
                string[] p = Console.ReadLine().Split();
                int a = int.Parse(p[0]);
                int b = int.Parse(p[1]);
                num += a * b;
            }
            if (X == num)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
