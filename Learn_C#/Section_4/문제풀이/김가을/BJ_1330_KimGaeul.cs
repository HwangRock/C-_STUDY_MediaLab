namespace Section4_BJ
{
	internal class BJ_1330_KimGaeul //두 수 
	{
		static void Main(string[] args)
		{
			string A, B, C;
			C = Console.ReadLine();
			A = C.Substring(0, 1);
			B = C.Substring(2, 1);

			int intA, intB;
			intA = int.Parse(A);
			intB = int.Parse(B);

			if (intA > intB)
			{
				Console.WriteLine(">");
			}
			else if (intA < intB)
			{
				Console.WriteLine("<");
			}
			else
			{
				Console.WriteLine("==");
			}

		}
	}
}