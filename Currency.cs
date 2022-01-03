using Godot;
using System;
using System.Collections.Generic;

namespace Engine.Models
{
		public class Nugget : GameItem
		{
		public int MinimumAmount { get; set; }
		public int MaximumAmount { get; set; }
		public int ValueofNugget{ get; set; }

			public Nugget (int itemTypeID, string name, string namePlural, int price, int minAmount, int maxAmount) : base(itemTypeID, namePlural, name, price, minAmount, maxAmount)
			{
			MinimumAmount = minAmount;
			MaximumAmount = maxAmount;
			ValueofNugget = price;
			MinAmount = minAmount;
			MaxAmount = maxAmount;
			}

		public new Nugget Clone()
		{
			return new Nugget(ItemTypeID, Name, NamePlural, Price, MinAmount, MaxAmount);
		}
	}
}

