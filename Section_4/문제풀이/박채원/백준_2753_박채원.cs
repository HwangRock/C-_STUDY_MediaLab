namespace CS_pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //백준 2753
            String str = Console.ReadLine();

            int num = int.Parse(str);

            if (num%4 == 0 && (num%100 != 0 || num%400==0))
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}
