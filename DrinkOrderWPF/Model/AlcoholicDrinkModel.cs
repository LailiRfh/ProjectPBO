using System.Text;

namespace DrinkOrderWPF.Model
{
	public class AlcoholicDrinkModel : BaseDrinkModel
	{
		public AlcoholicDrinkModel(string drinkType, bool isCarbonated, int alcoholContent)
		{
			base.DrinkCategory = Enum.DrinkCategory.Alcoholic;
			base.DrinkType = drinkType;
			base.AlcoholContent = alcoholContent;
			base.IsCarbonated = isCarbonated;
			base.IsAlcoholic = alcoholContent > 0;

			SetDescription();
		}

		private void SetDescription()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(base.DrinkType.ToString() + ", ");
			builder.Append(base.IsCarbonated ? "carbonated, " : "not carbonated, ");
			builder.Append(base.IsAlcoholic ? AlcoholContent.ToString() + "%. " : "0%. ");

			base.Description = builder.ToString();
		}
	}
}
