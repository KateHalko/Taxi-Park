using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace ConsoleApp1
{
	public static class Extensions
	{

		public static void ShowItems(this ITaxi taxi)
		{
	
			
			Console.WriteLine("TaxiPark: ");
			Console.WriteLine("Machine characteristics: ");
			foreach (var i in taxi.Items)
			{

				Console.WriteLine("Model: {0},Consumption: {1}, Speed:  {2},: Price {3},"
					, i.Model, i.Consumption, i.MaxSpeed, i.Price);
			}
		
		}
	}
}
