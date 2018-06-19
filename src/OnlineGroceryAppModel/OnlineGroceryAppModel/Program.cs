using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGroceryAppModel.Models;

namespace OnlineGroceryAppModel
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				context.OnlineGroceries.Add(new OnlineGrocery()
				{
					FoodName = "Orange",
					FoodCost = 2.99,
					FoodType = "Fruit",
					FoodQuantity = 5,
					PublishedOn = DateTime.Today
				});
				context.SaveChanges();

				var onlineGroceries = context.OnlineGroceries.ToList();
				foreach (var onlineGrocery in onlineGroceries)
				{
					Console.WriteLine(onlineGrocery.FoodName);
				}

				Console.ReadLine();
			}

		}
	}
}
