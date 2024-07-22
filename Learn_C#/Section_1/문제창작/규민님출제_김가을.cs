namespace Section1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string A, B, C;

			Console.Write("첫 번째 문자열을 입력하시오 : ");
			A = Console.ReadLine();

			Console.Write("두 번째 문자열을 입력하시오 : ");
			B = Console.ReadLine();

			Console.Write("세 번째 문자열을 입력하시오 : ");
			C = Console.ReadLine();

			Console.WriteLine(A + B + C);
		}
	}
}
