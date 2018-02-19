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
	    private int _totalToSplitBy;
	    private int _amountForEach;
	    private List<IParty> _parties;
	    private Player _newBowser;
	    private Player _oldBowser;

	    [SetUp]
	    public void SetUp()
	    {
		    _goldForKill = 1028;
		    var mickey = new Player { Name = "Mickey" };
		    var donald = new Player { Name = "Donald" };
		    var goofy = new Player { Name = "Goofy" };
		    var daisy = new Player { Name = "Daisy" };
		    var peach = new Player { Name = "Peach" };
		    _oldBowser = new Player {Name="Bowser"};
		    _newBowser = new Player {Name="NewBowser"};

			var bowsers = new Team {Members = {_oldBowser, _newBowser}};
		    var mages = new Team { Name = "Mages", Members = { mickey, donald, goofy, bowsers } };

			_parties = new List<IParty> { mages, daisy, peach };

		    _totalToSplitBy = _parties.Count;
		    _amountForEach = _goldForKill / _totalToSplitBy;
		}

	    [Test]
	    public void PartyGold()
	    {
		    var leftOver = _goldForKill % _totalToSplitBy;

		    foreach (var member in _parties)
		    {
			    member.Gold += _amountForEach + leftOver;
			    leftOver = 0;
			}

			Assert.AreEqual(43, _oldBowser.Gold);
			Assert.AreEqual(43, _newBowser.Gold);
			Assert.AreEqual(342, _parties[1].Gold);
	    }
    }
}
