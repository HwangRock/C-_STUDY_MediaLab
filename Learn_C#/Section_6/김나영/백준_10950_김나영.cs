using System.Runtime.ConstrainedExecution;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());


            for (int i = 1; i <= T; i++)
            {
                string[] ab = Console.ReadLine().Split(" ");
                   
                int A = int.Parse(ab[0]);
                int B = int.Parse(ab[1]);
                Console.WriteLine(A+B);
            }
        }
    }
}
