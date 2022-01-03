using Godot;
using System;
using Engine.Models;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Factories
{
	public static class ItemFactory
	{
		private static List<GameItem> _goldRushStandardGameItems;

		static ItemFactory()
		{ 
			_goldRushStandardGameItems = new List<GameItem>();

			_goldRushStandardGameItems.Add(new Clothing(1, "Underwear", "Underwears", 5, 1, 99));


			_goldRushStandardGameItems.Add(new Food(2, "Food", "Foods", 5, 1, 99));


			_goldRushStandardGameItems.Add(new Nugget(3, "Nugget", "Nuggets", 16, 1, 99));


			_goldRushStandardGameItems.Add(new Survival_Points(4, "Survival point", "Survival points", 1, 1, 99));

		}

		public static GameItem CreateGameItem(int itemTypeID)
		{
			GameItem standardItem = _goldRushStandardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

			if(standardItem != null)
			{
				return standardItem.Clone();
			}
			return null;
		}
	}
}
