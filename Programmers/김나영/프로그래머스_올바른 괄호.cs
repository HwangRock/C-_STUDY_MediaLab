using System.Diagnostics.Tracing;
using System.Runtime.ConstrainedExecution;

namespace 올바른괄호
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            string s = Console.ReadLine();
            for (int i = s[0]; i < args.Length; i+=2) //올바른 괄호라면 0포함 짝수계 다 "(" 테니까
            {
                if (i != "(")
                { answer = false;
                break}
                return answer;

            }



        }
    }
}
