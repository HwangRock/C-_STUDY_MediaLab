namespace CS_pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //백준 1330번
            String str = Console.ReadLine();

            string[] strs = str.Split(" "); //공백으로 구분

            int a = int.Parse(strs[0]);
            int b = int.Parse(strs[1]);

            if (a < b)
            {
                Console.WriteLine("<");
            }
            else if (a > b)
            {
                Console.WriteLine(">");
            }
            else //a==b
            {
                Console.WriteLine("=");
            }
        }
    }
}
