//문제 1.백준 2739번 구구단
//문제 링크 : https://www.acmicpc.net/problem/2739

int n = int.Parse(Console.ReadLine());
			for(int i = 1; i <= 9; i++)
			{
				Console.WriteLine(n + " * " + i + " = " + (n * i));
			}
