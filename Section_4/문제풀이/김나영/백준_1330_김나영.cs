namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(" ");
            int A = int.Parse(a[0]);
            int B = int.Parse(a[1]);

            if (A > B) { Console.WriteLine(">"); }

            else if (A<B) { Console.WriteLine("<"); }

            else { Console.WriteLine("=="); }
            
        }
    }
}
