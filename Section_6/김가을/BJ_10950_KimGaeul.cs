      			//문제 2.백준 10950 번 A +B
			//문제 링크 : https://www.acmicpc.net/problem/10950

      			int i = int.Parse(Console.ReadLine());
			int a, b;

			while(i > 0)
			{
				string[] num = Console.ReadLine().Split();
				a = int.Parse(num[0]);
				b = int.Parse(num[1]);
				Console.WriteLine(a + b);
				i--;
			}
