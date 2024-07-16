namespace CS_pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //백준 9498
            String str = Console.ReadLine();

            int num = int.Parse(str);

            if (num >= 90 && num <= 100)
            {
                Console.Write("A");
            }
            else if (num >= 80) //90미만
            {
                Console.Write("B");
            }
            else if (num >= 70) //80미만
            {
                Console.Write("C");
            }
            else if (num >= 60) //70미만
            {
                Console.Write("D");
            }
            else
            {
                Console.Write("F");
            }
        }
    }
}
