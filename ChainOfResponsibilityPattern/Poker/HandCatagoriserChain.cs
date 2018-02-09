using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibilityPattern.Poker
{
	public class HandCatagoriserChain
	{
		public HandCatagoriserChain()
		{
			Head = new RoyalFlushCatagoriser();
			Head.RegisterNext(new StraightFlushCatagoriser())
				.RegisterNext(new FourOfAKindCatagoriser());
		}

		public static HandRanking GetRank(Hand hand) => _instance.Head.Catagorise(hand);
		private HandCatagoriser Head { get; set; }
		private static readonly HandCatagoriserChain _instance = new HandCatagoriserChain();
	}

	public abstract class HandCatagoriser
	{
		public HandCatagoriser RegisterNext(HandCatagoriser next)
		{
			Next = next;
			return next;
		}

		protected  HandCatagoriser Next { get; set; }
		public abstract HandRanking Catagorise(Hand hand);

		protected static bool HasNofKind(int n, Hand hand) => false;

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