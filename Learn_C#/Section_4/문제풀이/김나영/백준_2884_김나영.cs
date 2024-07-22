namespace clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int set_T = int.Parse(input[0]);
            int set_M = int.Parse(input[1]);


            if (set_M >= 45) { set_M -= 45; }

            else if (set_T == 0 && set_M < 45)
            {
                set_T = 23;
                set_M = ((set_M + 60) - 45) % 60;
            }

            else if (set_M < 45)
            {
                set_T--;
                set_M = ((set_M + 60) - 45) % 60;
                
            }
            Console.WriteLine(set_T + " " + set_M);
        }
    }
}
