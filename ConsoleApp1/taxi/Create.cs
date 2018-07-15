using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class Creator
	{
		public abstract Car TaxiMethod(string CarModel, double CarCon, double CarSpeed, double CarPrise);
	}
}