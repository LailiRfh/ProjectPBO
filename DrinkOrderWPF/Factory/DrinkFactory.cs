using DrinkOrderWPF.Enum;
using DrinkOrderWPF.Model;
using System;
using System.Collections.Generic;

namespace DrinkOrderWPF.Factory
{
	public class DrinkFactory
	{
		public static BaseDrinkModel BuildDrink(DrinkCategory category, string drinkType, bool isCarbonated, int alcoholContent)
		{
			return category switch
			{
				DrinkCategory.Alcoholic => new AlcoholicDrinkModel(drinkType, isCarbonated, alcoholContent),
				DrinkCategory.Soda => new SodaDrinkModel(drinkType, alcoholContent),
				_ => throw new NotImplementedException("Drink category does not exist in the factory!")
			};
		}

		public static BaseDrinkModel BuildDrink(DrinkCategory category, string drinkType, bool isCarbonated, int alcoholContent, List<string> fruitTypes)
		{
			return category switch
			{
				DrinkCategory.Juice => new JuiceDrinkModel(drinkType, isCarbonated, alcoholContent, fruitTypes),
				_ => throw new NotImplementedException("Drink category does not exist in the factory!")
			};
		}
	}
}
