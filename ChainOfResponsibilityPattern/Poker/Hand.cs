using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Poker
{
	public class Hand
	{
		private readonly List<Card> _cards = new List<Card>();
		private HandRanking _rank = HandRanking.Unknown;

		public void Add(Card c)
		{
			if (_cards.Count == 5)
				throw new InvalidOperationException("Hand can not exceed 5 cards");
			_cards.Add(c);
			if (_cards.Count == 5)
				_rank = HandCatagoriserChain.GetRank(this);
		}

		public Card HighCard
		{
			get
			{
				if (_cards.Count == 0)
					throw new InvalidOperationException();
				return _cards[_cards.Count - 1];
			}
		}

		public IEnumerable<Card> Cards => _cards;

		public HandRanking Rank => _rank;

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var card in _cards)
			{
				sb.AppendFormat(card.ToString());
			}

			return sb.ToString();
		}
	}
}