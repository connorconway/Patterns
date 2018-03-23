using System;
using System.Drawing;
using FlyweightPattern.Library;
using FlyweightPattern.Model;
using NUnit.Framework;

namespace FlyweightPattern.Tests
{
	[TestFixture]
	public class TilesTests
	{
		private readonly Random _rand = new Random();

		[Test]
		public void Draw_CeramicTile()
		{
			for (var i = 0; i < 20; i++)
			{
				ITile tile = new CeramicTile(x: RandomNumber, y: RandomNumber, width: RandomNumber, height: RandomNumber);
				tile.Draw(new FakeGraphicsAdapter());
			}
		}

		[Test]
		public void Draw_StoneTile()
		{
			for (var i = 0; i < 20; i++)
			{
				ITile tile = new StoneTile(x: RandomNumber, y: RandomNumber, width: RandomNumber, height: RandomNumber);
				tile.Draw(new FakeGraphicsAdapter());
			}
		}

		private int RandomNumber => _rand.Next(100);
	}
}