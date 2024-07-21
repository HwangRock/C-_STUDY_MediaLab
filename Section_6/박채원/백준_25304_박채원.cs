namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 25304
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int a, b;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();

                a = int.Parse(str[0]);
                b = int.Parse(str[1]);

                sum += a * b;
            }
            if (sum == x) 
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
         }
     }
 }
