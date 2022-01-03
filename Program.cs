using System;
using System.Collections.Generic;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int Price { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }

        public GameItem(int itemTypeID, string name, string namePlural, int price, int minAmount, int maxAmount)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            NamePlural = namePlural;
            Price = price;
            MinAmount = minAmount;
            MaxAmount = maxAmount;

        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, NamePlural, Price, MinAmount, MaxAmount);
        }
    }
}