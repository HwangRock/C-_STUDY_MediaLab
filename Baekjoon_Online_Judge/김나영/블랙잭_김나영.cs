using Microsoft.VisualBasic;

namespace blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(" ");
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            String[] Ns =Console.ReadLine().Split();
            int[] intN = Array.ConvertAll(Ns, s => int.Parse(s));
            int A = 0;

            for (int i = 0; i < intN.Length; i++)
            {
                for (int j = i+1; j < intN.Length; j++)
                {
                    int sum = intN[i] + intN[j] + intN[j + 1];
                    if(sum <= M)
                    { if(sum > A)
                       {  A = sum; }
                    }
                }
            }

            Console.WriteLine(A);

        }
    }
}
