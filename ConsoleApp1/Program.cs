using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
			
		{ //добавь в файл свои данные о машинах через точку с запятой 
			StreamReader fs = new StreamReader("test1.txt");//(текстовый файл находится : Laba_3/ConsoleApp1/bin/Debug)
			Creator[] creators = new Creator[1];
			creators[0] = new TaxiCreator();
			ITaxi taxi = new Taxi();
			string[] lines = Array.FindAll(fs.ReadToEnd().Split('\n'), (line) => line.Length > 0);

			foreach (var line in lines)
			{ // txt data format - DSV delimer is ';'
				string[] inits = Array.FindAll(line.Split(';'), (item) => item.Length > 0);

				taxi.Add(new tax(inits[0], double.Parse(inits[1]), 
					double.Parse(inits[2]), double.Parse(inits[3])));
				// StringSplitOptions.RemoveEmptyEntries можно передовать в Split как option arg
			}
			fs.Close();
			taxi.Sort();
			taxi.ShowItems();
			FileStream file = new FileStream("test.txt", FileMode.Create);
			StreamWriter writer = new StreamWriter(file);
			writer.WriteLine("TaxiPark: ");
			writer.WriteLine("Machine characteristics: ");
			foreach (var i in taxi.Items)
			{

				writer.WriteLine("Model: {0},Consumption: {1}, Speed:  {2},: Price {3},"
					, i.Model, i.Consumption, i.MaxSpeed, i.Price);
			}
			
			double From, To;
			Console.WriteLine(" Enter the  range of speed parameters: \n");
			From = Convert.ToDouble(Console.ReadLine());
			To = Convert.ToDouble(Console.ReadLine());
			writer.WriteLine();

			foreach (var items in taxi.FindCarBySpeed(From, To))
			{
				Console.WriteLine("Model : {0}, Speed: {1}", items.Model, items.MaxSpeed);
			}
			foreach (var items in taxi.FindCarBySpeed(From, To))
			{
				writer.WriteLine("Model : {0}, Speed: {1}", items.Model, items.MaxSpeed);
			}
			writer.WriteLine();
			writer.WriteLine("Cost of the taxipark: {0}", taxi.TaxiCost());
			writer.Close();
			Console.ReadKey();
		}
	}
}

