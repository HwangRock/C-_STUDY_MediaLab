using System.Runtime.ConstrainedExecution;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;


            for (int i = 1; i <= n; i++)
            {
                num += i;
            }
            Console.WriteLine(num);
        }
    }
}
