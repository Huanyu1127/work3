using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{//1*2*3*4*5 5!
			int result = 1;
			for(int i = 1; i <=5; i++)
			{
				result = result * i;
			}
			Console.WriteLine($"{result}");
		}
	}
}
