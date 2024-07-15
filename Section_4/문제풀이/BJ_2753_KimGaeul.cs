using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_BJ
{
	internal class BJ_2753_KimGaeul //윤년
	{
		static void Main(string[] args)
		{
			int year;
			year = int.Parse(Console.ReadLine());

			if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
			{
				Console.WriteLine("1");
			}
			else
			{
				Console.WriteLine("0");
			}
		}
	}
}
