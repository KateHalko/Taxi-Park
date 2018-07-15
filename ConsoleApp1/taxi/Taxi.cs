using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Taxi : ITaxi
	{
		private ICollection<Car> items;
		public Taxi()
		{
			items = new List<Car>();

		}
		public void Add(Car Cars)
		{
			items.Add(Cars);

		}
		public double TaxiCost()
		{
			return items.Sum( x=>x.Price);
		}
	    public void Sort()
	    {
		var temp = items.OrderBy(x => x.Price).ToList();
		items.Clear();
		foreach (var item in temp)
		{
			items.Add(item);
		}
   	    }
		public IEnumerable<Car> FindCarBySpeed(double From, double To)
		{
			return items.Where(x => (x.MaxSpeed >= From) && (x.MaxSpeed <= To)).ToList();
		}
		public IEnumerable<Car> Items
		{
			get { return this.items; }
		}
	}
}
