namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 10950
            string str = Console.ReadLine();

            int T = int.Parse(str);

            int num1;
            int num2;

            for (int i = 0; i < T; i++)
            {
                string[] str1 = Console.ReadLine().Split();

                num1 = int.Parse(str1[0]);
                num2 = int.Parse(str1[1]);

                Console.WriteLine(num1 + num2);
            }

        }
    }
}
