using System.Collections.Generic;
using System.Text;
using CompositePattern.Library;

namespace CompositePattern.Model
{
	public class Team : IParty
	{
		public List<IParty> Members { get; } = new List<IParty>();

		public int Gold
		{
			get
			{
				var totalGold = 0;
				foreach (var member in Members)
				{
					totalGold += member.Gold;
				}

				return totalGold;
			}
			set
			{
				var eachSplit = value / Members.Count;
				var leftOver = value % Members.Count;
				foreach (var member in Members)
				{
					member.Gold += eachSplit + leftOver;
					leftOver = 0;
				}
			}
		}

		public string Stats()
		{
			var totalStats = new StringBuilder();
			foreach (var member in Members)
			{
				totalStats.AppendLine(member.Stats());
			}
			return totalStats.ToString();
		}
	}
}