      //문제 4.백준 25304 번 영수증
			//문제 링크 : https://www.acmicpc.net/problem/25304

      int price, n, a, b, sum;
			sum = 0;
			string[] num;
			
			price = int.Parse(Console.ReadLine());
			n = int.Parse(Console.ReadLine());
			int[ , ] numbers = new int[n, 3];

			for (int i = 0; i < n; i++)
			{
				num = Console.ReadLine().Split();
				a = int.Parse(num[0]);
				b = int.Parse(num[1]);
				numbers[i, 0] = a;
				numbers[i, 1] = b;
				numbers[i, 2] = a * b;
				sum += numbers[i, 2];
			}

			if(price == sum)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
			
