namespace ChainOfResponsibilityPattern.Poker
{
	public class RoyalFlushCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasFlush(hand) && HasStraight(hand) && hand.HighCard.Val == Value.Ace)
				return HandRanking.RoyalFlush;
			return Next.Catagorise(hand);
		}
	}

	public class StraightFlushCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasStraight(hand))
				return HandRanking.StraightFlush;
			return Next.Catagorise(hand);
		}
	}

	public class FourOfAKindCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNofKind(4, hand))
				return HandRanking.FourOfAKind;
			return Next.Catagorise(hand);
		}
	}

	public class PairCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNofKind(2, hand))
				return HandRanking.Pair;
			return Next.Catagorise(hand);
		}
	}

	public class HighCardCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			return HandRanking.HighCard;
		}
	}
}