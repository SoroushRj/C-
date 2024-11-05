using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter First Number: ");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Second Number: ");
			int y = int.Parse(Console.ReadLine());

			Console.WriteLine("Average = " + ((x + y) / 2));
			Console.WriteLine("Press Any Key To Continue...");
			Console.ReadKey();
		}
	}
}
