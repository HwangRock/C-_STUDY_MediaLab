namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int x = int.Parse(str1);
            int y = int.Parse(str2);

            //사분면 판단
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
        }
    }
}
