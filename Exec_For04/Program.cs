using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//呈現1~20, 若是3的倍數顯示 foo, 若是5的倍數顯示bar, 若是15的倍數顯示foobar, 其餘顯示數值
			for (int i = 1; i <= 20; i++)
			{

				if ( i>=15 && i % 15 == 0)
				{
					string fifteen = i.ToString();
					fifteen = "　foobar";
					Console.Write(fifteen);
					
				}
				else if (i >= 5 && i % 5 == 0)
				{
					string five = i.ToString();
					five = "　bar";
					Console.Write(five);
				}
				else if (i >= 3 && i % 3 == 0)
				{
					string three = i.ToString();
					three = "　foo";
					Console.Write(three);
				}
				else
				{ Console.Write("　"+i); }
			}
		}
	}
}
