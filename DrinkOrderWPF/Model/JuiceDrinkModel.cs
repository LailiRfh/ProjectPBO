using System.Collections.Generic;
using System.Text;

namespace DrinkOrderWPF.Model
{
	public class JuiceDrinkModel : BaseDrinkModel
	{
		public List<string> FruitTypes { get; }

		public JuiceDrinkModel(string drinkType, bool isCarbonated, int alcoholContent, List<string> fruitTypes)
		{
			base.DrinkCategory = Enum.DrinkCategory.Juice;
			base.DrinkType = drinkType;
			base.IsCarbonated = isCarbonated;
			base.IsAlcoholic = alcoholContent > 0;
			base.AlcoholContent = alcoholContent;
			FruitTypes = fruitTypes;

			SetDescription();
		}

		private void SetDescription()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(base.DrinkType.ToString() + ", ");
			builder.Append(base.IsCarbonated ? "carbonated" : "not carbonated");

			if (FruitTypes.Count > 0)
			{
				builder.Append(", ");
				builder.Append(FruitTypes.Count > 0 ? "made from " + string.Join(", ", FruitTypes.ToArray()) : string.Empty);
			}
			
			if (IsAlcoholic)
			{
				builder.Append(", ");
				builder.Append(base.IsAlcoholic ? AlcoholContent.ToString() + "%. " : ". ");
			}
			else
			{
				builder.Append(".");
			}

			base.Description = builder.ToString();
		}
	}
}
