using System;
using System.Collections.Generic;

namespace Engine.Models
{
	public class Clothing : GameItem
	{
		public int MinimumStorage { get; set; }
		public int MaximumStorage { get; set; }
		public int PriceofClothing { get; set; }

		public Clothing(int itemTypeID, string name, string namePlural, int price, int minAmount, int maxAmount) : base(itemTypeID, namePlural, name, price, minAmount, maxAmount)
		{
			MinimumStorage = minAmount;
			MaximumStorage = maxAmount;
			PriceofClothing = price;
			MinAmount = minAmount;
			MaxAmount = maxAmount;
		}

		public new Clothing Clone()
		{
			return new Clothing(ItemTypeID, Name, NamePlural, Price, MinAmount, MaxAmount);
		}
	}
}
