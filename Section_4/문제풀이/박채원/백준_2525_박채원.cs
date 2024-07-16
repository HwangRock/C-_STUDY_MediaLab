namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 2525
            string[] str1 = Console.ReadLine().Split(" ");
            string str2 = Console.ReadLine();

            int h = int.Parse(str1[0]);
            int m = int.Parse(str1[1]);
            int time = int.Parse(str2);

            int sum = 0;

            sum = h * 60 + m + time;

            if (sum / 60 >= 24)
            {
                sum -= 24 * 60;
            }

            
            Console.WriteLine(sum / 60 + " " + sum % 60);

        }
    }
}
