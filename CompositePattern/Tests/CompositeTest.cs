using CompositePattern.Model;
using NUnit.Framework;

namespace CompositePattern.Tests
{
	[TestFixture]
    public class CompositeTest
    {
	    private const int GoldToSplit = 1028;

		[Test]
	    public void PartyGoldSplit()
	    {
		    var mickey = new Player { Name = "Mickey" };
		    var donald = new Player { Name = "Donald" };
		    var goofy = new Player { Name = "Goofy" };
		    var daisy = new Player { Name = "Daisy" };
		    var peach = new Player { Name = "Peach" };
		    var oldBowser = new Player { Name = "OldBowser" };
		    var newBowser = new Player { Name = "NewBowser" };

		    var bowsers = new Team { Members = { oldBowser, newBowser } };
		    var mages = new Team { Members = { mickey, donald, goofy, bowsers } };

		    var root = new Team { Members = { mages, daisy, peach } };

			root.Gold += GoldToSplit;

			Assert.AreEqual(342, daisy.Gold);
			Assert.AreEqual(342, peach.Gold);
			Assert.AreEqual(86, mickey.Gold);
			Assert.AreEqual(86, donald.Gold);
			Assert.AreEqual(86, goofy.Gold);
			Assert.AreEqual(43, oldBowser.Gold);
			Assert.AreEqual(43, newBowser.Gold);
	    }
    }
}
