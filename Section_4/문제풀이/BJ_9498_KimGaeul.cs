using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_BJ
{
	internal class BJ_9498_KimGaeul //시험성적
	{
		static void Main(string[] args)
		{
			int score;
			score = int.Parse(Console.ReadLine());

			switch (score / 10)
			{
				case 10: Console.WriteLine("A"); break;
				case 9: Console.WriteLine("A"); break;
				case 8: Console.WriteLine("B"); break;
				case 7: Console.WriteLine("C"); break;
				case 6: Console.WriteLine("D"); break;
				default: Console.WriteLine("F"); break;

			}
		}
	}
}
