using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_BJ
{
	internal class BJ_14681_KimGaeul //사분면 고르기
	{
		static void Main(string[] args)
		{
			int x, y;
			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());

			if (x > 0 && y > 0) { Console.WriteLine("1"); }
			else if (x > 0 && y < 0) { Console.WriteLine("4"); }
			else if (x < 0 && y < 0) { Console.WriteLine("3"); }
			else { Console.WriteLine("2"); }
		}
	}
}
