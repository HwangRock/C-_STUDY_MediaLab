namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 2438
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
