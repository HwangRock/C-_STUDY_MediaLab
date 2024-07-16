namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string X = Console.ReadLine();
            int numX = int.Parse(X);

            if (numX>=90) { Console.WriteLine("A"); }

            else if (numX >= 80) { Console.WriteLine("B"); }

            else if (numX >= 70) { Console.WriteLine("C"); }

            else if (numX >= 60) { Console.WriteLine("D"); }

            else { Console.WriteLine("F"); }


        }
    }
}
