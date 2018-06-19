using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryAppModel.Models
{
	public class OnlineGrocery
	{
		// ID, OnlineGroceryId, OnlineGroceryID
		public int Id { get; set; }
		public string FoodName { get; set; }
		public double FoodCost { get; set; }
		public string FoodType { get; set; }
		public int FoodQuantity { get; set; }
		public DateTime PublishedOn { get; set; }
	}
}
