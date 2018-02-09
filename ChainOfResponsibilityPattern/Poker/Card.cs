namespace ChainOfResponsibilityPattern.Poker
{
	public class Card
	{
		public Suit Suit { get; private set; }
		public Value Val { get; private set; }

		public Card(Suit suit, Value val)
		{
			Suit = suit;
			Val = val;
		}

		public override string ToString() => Suit.ToString() + Val.ToString();
	}
}