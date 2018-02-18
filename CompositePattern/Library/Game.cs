using CompositePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Library
{
	class Game
	{
		private List<Player> _players;
		private List<Team> _teams;

		public Game(List<Player> players, List<Team> teams)
		{
			_players = players;
			_teams = teams;
		}
	}
}
