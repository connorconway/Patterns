using CompositePattern.Model;
using NUnit.Framework;

namespace CompositePattern.Tests
{
	[TestFixture]
    public class CompositeTest
    {
	    private int _goldForKill;
	    private Team _root;
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
		    var mages = new Team { Members = { mickey, donald, goofy, bowsers } };

			_root = new Team { Members = { mages, daisy, peach} };

	    }

	    [Test]
	    public void PartyGold()
	    {
		    _root.Gold += _goldForKill;

			Assert.AreEqual(43, _oldBowser.Gold);
			Assert.AreEqual(43, _newBowser.Gold);
	    }
    }
}
