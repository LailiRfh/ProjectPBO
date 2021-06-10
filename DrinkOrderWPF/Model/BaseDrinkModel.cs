using DrinkOrderWPF.Enum;
using DrinkOrderWPF.Interfaces;

namespace DrinkOrderWPF.Model
{
	public class BaseDrinkModel : IDrink
	{
		public DrinkCategory DrinkCategory { get; set; }
		public string DrinkType { get; set; }
		public string Description { get; set; }
		public bool IsCarbonated { get; set; }
		public bool IsAlcoholic { get; set; }
		public int AlcoholContent { get; set; }

		public string GetDescription()
		{
			return Description;
		}
	}
}
