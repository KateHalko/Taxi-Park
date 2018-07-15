using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class Car
	{
		public string Model { get;  set; }
		public double Consumption { get; set; }
		public double MaxSpeed { get;  set; }
		public double Price { get; set; }
		
		public Car(string CarModel, double CarCon, double CarSpeed, double CarPrise)
		{
			this.Model = CarModel;
			this.Consumption = CarCon;
			this.MaxSpeed = CarSpeed;
			this.Price = CarPrise;
		}
	}
}
