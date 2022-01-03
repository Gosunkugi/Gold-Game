using System;
using System.Collections.Generic;

namespace Engine.Models
{
	public class Food : GameItem
	{
		public int MinimumStorage { get; set; }
		public int MaximumStorage { get; set; }
		public int PriceofFood { get; set; }

		public Food(int itemTypeID, string name, string namePlural, int price, int minAmount, int maxAmount) : base(itemTypeID, namePlural, name, price, minAmount, maxAmount)
		{
			MinimumStorage = minAmount;
			MaximumStorage = maxAmount;
			PriceofFood = price;
			MinAmount = minAmount;
			MaxAmount = maxAmount;
		}
		public new Food Clone()
		{
			return new Food(ItemTypeID, Name, NamePlural, Price, MinAmount, MaxAmount);
		}
	}
}

