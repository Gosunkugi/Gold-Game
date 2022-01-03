using System;
using System.Collections.Generic;

namespace Engine.Models
{
    public class Survival_Points : GameItem
    {
        public int MinimumAmount { get; set; }
        public int MaximumAmount { get; set; }
        public int ValueofSurvivalPoints { get; set; }

        public Survival_Points(int itemTypeID, string name, string namePlural, int price, int minAmount, int maxAmount) : base(itemTypeID, namePlural, name, price, minAmount, maxAmount)
        {
            MinimumAmount = minAmount;
            MaximumAmount = MaximumAmount;
            ValueofSurvivalPoints = price;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
        }

        public new Survival_Points Clone()
        {
            return new Survival_Points(ItemTypeID, Name, NamePlural, Price, MinAmount, MaxAmount);
        }
    }
}
