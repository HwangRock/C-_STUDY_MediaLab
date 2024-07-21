namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 25314
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 4; i++) 
            {
                Console.Write("long ");
            }
            Console.Write("int");
        }
    }
}
