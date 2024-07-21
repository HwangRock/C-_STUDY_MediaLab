using System.Globalization;

namespace 약수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 1; i <= n ; i++)
            {
                if (n % i == 0)
                {
                    num += i;
                }

            }
            Console.WriteLine(num);
        }
    }
}
