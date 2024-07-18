
			//문제 5.백준 25314 번 코딩은 체육과목입니다.
			//문제 링크 : https://www.acmicpc.net/problem/25314

      			int n = int.Parse(Console.ReadLine());

			while(n / 4 > 0) 
			{
				Console.Write("long ");
				n -= 4;
			}
			Console.WriteLine("int");
