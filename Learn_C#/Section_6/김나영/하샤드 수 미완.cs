namespace 하샤드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split();

            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);
            t = int.Parse(x.ToString()); //오류!!

            if (t % (a + b) == 0)
            {
                Console.WriteLine("true");
            }
            else if (t % (a + b) != 0)
            {
                Console.WriteLine("false");
            }
            else {
                Console.WriteLine("return"); 
            }


        }
    }
}
