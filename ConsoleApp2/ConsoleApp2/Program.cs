using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2;
			Console.WriteLine("enter first number");
			num1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("enter second number");
			num2 = Convert.ToInt16(Console.ReadLine());
			num1 = num1 + num2;
			num2 = num1 - num2;
			num1 = num1 - num2;
			Console.WriteLine("After swapping: num1 = "
							  + num1 + ", num2 = " + num2);

		}
	}
}
