using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//++++1
			//+++22
			//++333
			//+4444
			//5555
			for (int i = 1; i <= 5; i++)
			{
				string star = new string('+', 5 - i);
				Console.Write(star);

				for (int k = i; k >= 1; k--)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}
		}
	}
}
