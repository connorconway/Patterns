using System.Collections.Generic;
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
		    _individuals = new List<Player> { daisy, peach };
		    _groups = new List<Team> { mages };
		    _totalToSplitBy = _individuals.Count + _groups.Count;
		    _amountForEach = _goldForKill / _totalToSplitBy;
		}

	    [Test]
	    public void IndividualPlayersStats()
	    {
		    var leftOver = _goldForKill % _totalToSplitBy;

		    foreach (var individual in _individuals)
		    {
			    individual.Gold += _amountForEach + leftOver;
			    leftOver = 0;
				Assert.AreEqual(individual.Stats(), $"{individual.Name} : {individual.Gold}");
		    }
	    }

		[Test]
	    public void GroupPlayerStats()
	    {
		    foreach (var group in _groups)
		    {
			    var amountForEachGroupMember = _amountForEach / group.Members.Count;
			    var leftOverForGroup = amountForEachGroupMember % group.Members.Count;
			    foreach (var member in group.Members)
			    {
				    member.Gold += amountForEachGroupMember + leftOverForGroup;
				    leftOverForGroup = 0;
				    var stats = member.Stats();
					Assert.AreEqual(stats, $"{member.Name} : {member.Gold}");
			    }
		    }
		}
    }
}
