      //문제 6.백준 2438 번 별찍기
			//문제 링크 : https://www.acmicpc.net/problem/2438

      int n = int.Parse(Console.ReadLine());
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < i + 1; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
