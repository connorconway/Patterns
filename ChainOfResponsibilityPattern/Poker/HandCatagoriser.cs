using System.Linq;

namespace ChainOfResponsibilityPattern.Poker
{
	public abstract class HandCatagoriser
	{
		public HandCatagoriser RegisterNext(HandCatagoriser next)
		{
			Next = next;
			return next;
		}

		protected  HandCatagoriser Next { get; set; }
		public abstract HandRanking Catagorise(Hand hand);

		protected static bool HasNoOfKind(int n, Hand hand) => false;

		protected static bool HasStraight(Hand hand) => false;
		 
		protected static bool HasFlush(Hand hand)
		{
			var suits = hand.Cards.Select(c => c.Suit).ToList();
			suits.Sort();
			var expected = suits[0];
			return suits.All(s => s == expected);
		}
	}
}