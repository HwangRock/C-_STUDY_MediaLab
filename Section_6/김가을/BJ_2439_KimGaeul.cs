
			//문제 7.백준 2439 번 별찍기
			//문제 링크 : https://www.acmicpc.net/problem/2439

      int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				for (int j = 1; j < n - i; j++)
				{
					Console.Write(" ");
				}
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
