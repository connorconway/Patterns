namespace ChainOfResponsibilityPattern.Poker
{
	public class HandCatagoriserChain
	{
		private static readonly HandCatagoriserChain Instance = new HandCatagoriserChain();
		private HandCatagoriser Head { get; }

		public HandCatagoriserChain()
		{
			Head = new RoyalFlushCatagoriser()
				.RegisterNext(new StraightFlushCatagoriser())
				.RegisterNext(new FourOfAKindCatagoriser())
				.RegisterNext(new FullHouseCatagoriser())
				.RegisterNext(new FlushCatagoriser())
				.RegisterNext(new StraightCatagoriser())
				.RegisterNext(new ThreeOfAKindCatagoriser())
				.RegisterNext(new TwoPairCatagoriser())
				.RegisterNext(new PairCatagoriser())
				.RegisterNext(new HighCardCatagoriser());
		}

		public static HandRanking GetRank(Hand hand) =>  Instance.Head.Catagorise(hand);
	}
}