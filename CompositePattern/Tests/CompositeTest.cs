using System;
using System.Collections.Generic;
using CompositePattern.Library;
using CompositePattern.Model;
using NUnit.Framework;

namespace CompositePattern.Tests
{
	[TestFixture]
    public class CompositeTest
    {
	    private int _goldForKill;
	    private List<Player> _individuals;
	    private List<Team> _groups;
	    private int _totalToSplitBy;
	    private int _amountForEach;
	    private List<IParty> _parties;

	    [SetUp]
	    public void SetUp()
	    {
		    _goldForKill = 1028;
		    var mickey = new Player { Name = "Mickey" };
		    var donald = new Player { Name = "Donald" };
		    var goofy = new Player { Name = "Goofy" };
		    var daisy = new Player { Name = "Daisy" };
		    var peach = new Player { Name = "Peach" };
		    var mages = new Team { Name = "Mages", Members = { mickey, donald, goofy } };

		    _parties = new List<IParty> { mages, daisy, peach };

		    _totalToSplitBy = _parties.Count;
		    _amountForEach = _goldForKill / _totalToSplitBy;
		}

	    [Test]
	    public void PartyStats()
	    {
		    var leftOver = _goldForKill % _totalToSplitBy;

		    foreach (var member in _parties)
		    {
			    member.Gold += _amountForEach + leftOver;
			    leftOver = 0;
			}
	    }
    }
}
