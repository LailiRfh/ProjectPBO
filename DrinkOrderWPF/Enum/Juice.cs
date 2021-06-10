namespace DrinkOrderWPF.Enum
{
	public enum Juice
	{
		AppleJuice,
		CherryJuice,
		LemonJuice,
		MangoJuice,
		OrangeJuice
	}

	public static class ExtensionHelpers
	{
		public static string ToFriendlyString(this Juice juiceType)
		{
			return juiceType switch
			{
				Juice.AppleJuice => "Apple Juice",
				Juice.CherryJuice => "Cherry Juice",
				Juice.MangoJuice => "Mango Juice",
				Juice.LemonJuice => "Lemon Juice",
				Juice.OrangeJuice => "Orange Juice",
				_ => "No Type Was Selected",
			};
		}
	}
}
