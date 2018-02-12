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
			if (HasStraight(hand) && HasFlush(hand))
				return HandRanking.StraightFlush;
			return Next.Catagorise(hand);
		}
	}

	public class FourOfAKindCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNoOfKind(4, hand))
				return HandRanking.FourOfAKind;
			return Next.Catagorise(hand);
		}
	}

	public class FullHouseCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNoOfKind(3, hand) && HasNoOfKind(2, hand))
				return HandRanking.FullHouse;
			return Next.Catagorise(hand);
		}
	}

	public class FlushCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasFlush(hand))
				return HandRanking.Flush;
			return Next.Catagorise(hand);
		}
	}

	public class StraightCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasStraight(hand))
				return HandRanking.Straight;
			return Next.Catagorise(hand);
		}
	}

	public class ThreeOfAKindCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNoOfKind(3, hand))
				return HandRanking.ThreeOfAKind;
			return Next.Catagorise(hand);
		}
	}

	public class TwoPairCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNoOfKind(2, hand) && HasNoOfKind(2, hand))
				return HandRanking.TwoPair;
			return Next.Catagorise(hand);
		}
	}

	public class PairCatagoriser : HandCatagoriser
	{
		public override HandRanking Catagorise(Hand hand)
		{
			if (HasNoOfKind(2, hand))
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