namespace 하샤드
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = x;         

            while (x > 0)
            {                
                sum += x % 10;
                x = x / 10;
            }
            if(a% sum == 0)
            {
                Console.WriteLine("true");
            }
            else if (a% sum != 0)
            {
                Console.WriteLine("false");
            }
            else { Console.WriteLine("return"); }

        }
    }
}
