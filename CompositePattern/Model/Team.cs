using System.Collections.Generic;

namespace CompositePattern.Model
{
	public class Team
	{
		public string Name { get; set; }
		public List<Player> Members { get; set; }

		public Team()
		{
			Members = new List<Player>();
		}
	}
}