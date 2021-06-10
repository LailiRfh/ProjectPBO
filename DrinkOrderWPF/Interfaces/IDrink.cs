using DrinkOrderWPF.Enum;

namespace DrinkOrderWPF.Interfaces
{
	public interface IDrink
	{
		public DrinkCategory DrinkCategory { get; set; }
		public string DrinkType { get; set; }
		public string Description { get; set; }
		public string GetDescription()
		{
			return Description;
		}
	}
}
