using DrinkOrderWPF.Enum;
using System.Text;

namespace DrinkOrderWPF.Model
{
	public class SodaDrinkModel : BaseDrinkModel
	{
		public SodaDrinkModel(string drinkType, int alcoholContent)
		{
			base.AlcoholContent = alcoholContent;
			base.IsAlcoholic = alcoholContent > 0;
			base.DrinkCategory = DrinkCategory.Soda;
			base.DrinkType = drinkType;
			base.IsCarbonated = true;

			SetDescription();
		}

		private void SetDescription()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(base.DrinkType.ToString() + ", ");
			builder.Append(base.IsCarbonated ? "carbonated" : "not carbonated");

			if (IsAlcoholic)
			{
				builder.Append(", ");
				builder.Append(AlcoholContent.ToString() + "%. ");
			}
			else
			{
				builder.Append(".");
			}

			base.Description = builder.ToString();
		}
	}
}
