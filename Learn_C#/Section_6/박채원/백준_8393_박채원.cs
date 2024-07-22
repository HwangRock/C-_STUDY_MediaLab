namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 8393
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
