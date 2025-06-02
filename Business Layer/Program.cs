using System.Text.Json;

namespace BusinessLayer
{
	public class DarkestHourCard()
	{
		public string Rarity { get; set; }
		public int Number { get; set; }
		public string CardType { get; set; }
		public string FlavorText { get; set; }
		public int CastingCost { get; set; }
		public string ManaType { get; set; }
		public string Artist { get; set; }
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			DarkestHourCard card = new DarkestHourCard();
			card.Rarity = "R";
			card.Number = 128;
			card.CardType = "Enchantment";
			card.FlavorText = "yo mama";
			card.CastingCost = 1;
			card.ManaType = "Black";
			card.Artist = "Heather Hudson";

			string jsonString = JsonSerializer.Serialize(card);

			File.WriteAllText("DarkestHour.json", jsonString);
		}
	}
}
