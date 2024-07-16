namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 2884
            string[] str = Console.ReadLine().Split(" ");

            int hour = int.Parse(str[0]);
            int min = int.Parse(str[1]);

            if (min >= 45){
                min -= 45;
                Console.WriteLine(hour + " " + min);
            }
            else
            {
                hour--;
                min += 60;
                min -= 45;

                if(hour < 0)
                {
                    hour += 24;
                }

                Console.WriteLine(hour + " " + min);
            }

        }
    }
}
