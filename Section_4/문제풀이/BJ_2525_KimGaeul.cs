using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_BJ
{
	internal class BJ_2525_KimGaeul //오븐시계
	{
		static void Main(string[] args)
		{
			int h, m, time;
			string input;
			input = Console.ReadLine();
			string[] input_array = input.Split('\x020');
			h = int.Parse(input_array[0]);
			m = int.Parse(input_array[1]);
			time = int.Parse(Console.ReadLine());

			if (m + time < 60)
			{
				Console.WriteLine(h + " " + (m + time));
			}
			else if (m + time >= 60)
			{
				h += time / 60;
				m += time % 60;

				if (m >= 60)
				{
					h += 1;
					m -= 60;
				}
				if (h >= 24)
				{
					h -= 24;
				}

				Console.WriteLine(h + " " + m);
			}
		}
	}
}
