using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter num: ");
			int num = int.Parse(Console.ReadLine());
			int days = num % 30;
			int months = num / 30;
			Console.WriteLine(months+" Months & "+days+" days");
			Console.ReadLine();
		}
	}
}
