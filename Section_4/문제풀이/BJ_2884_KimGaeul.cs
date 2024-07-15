using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4_BJ
{
	internal class BJ_2884_KimGaeul //알람시계
	{
		static void Main(string[] args)
		{
			int h, m, h_r, m_r;
			string input;
			input = Console.ReadLine();
			string[] input_array = input.Split('\x020');
			h = int.Parse(input_array[0]);
			m = int.Parse(input_array[1]);

			if (m > 45)
			{
				Console.WriteLine(h + " " + (m - 45));
			}
			else
			{
				
				if (h == 0)
				{
					Console.WriteLine((h + 23) + " " + (m + 15));
				}
				else
				{
					Console.WriteLine((h - 1) + " " + (m + 15));
				}

			}
		}
	}
}
