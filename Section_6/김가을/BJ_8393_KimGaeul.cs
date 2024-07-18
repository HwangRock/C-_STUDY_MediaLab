      //문제 3.백준 8393 번 합
			//문제 링크 : https://www.acmicpc.net/problem/8393

      int n = int.Parse(Console.ReadLine());
			int sum = 0;

			while (n > 0)
			{
				sum += n;
				n--;
			}

			Console.WriteLine(sum);
