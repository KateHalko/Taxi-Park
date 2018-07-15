using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public  class TaxiCreator : Creator
	{
		public override Car TaxiMethod(string CarModel, double CarCon, double CarSpeed, double CarPrise)
		{
			return new tax(CarModel, CarCon, CarSpeed, CarPrise);
		}
		
	}
}