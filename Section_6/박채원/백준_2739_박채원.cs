namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //백준 2739
            string str = Console.ReadLine();
            int num = int.Parse(str);

            for(int i = 1; i <= 9;  i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num *i);
            }
        }
    }
