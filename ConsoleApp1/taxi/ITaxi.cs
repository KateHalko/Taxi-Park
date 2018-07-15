using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public interface ITaxi
	{
		IEnumerable<Car> Items { get; }
		void Add(Car Cars);
		double TaxiCost();
		void Sort();
		
		IEnumerable<Car> FindCarBySpeed(double From , double To);
		//void FindCarBySpeed(double min, double max);
	}
}
