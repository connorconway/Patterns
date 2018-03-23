using System;
using FlyweightPattern.Library;
using FlyweightPattern.Model;
using NUnit.Framework;

namespace FlyweightPattern.Tests
{
	[TestFixture]
	public class TilesTests
	{
		private readonly Random _rand = new Random();
		private FakeGraphicsAdapter _graphics;

		[SetUp]
		public void SetUp()
		{
			_graphics = new FakeGraphicsAdapter();
		}

		[Test]
		public void Draw_CeramicTile()
		{
			
			for (var i = 0; i < 20; i++)
			{
				var tile = TileFactory.GetTile(TileType.Ceramic);
				tile.Draw(_graphics, x: RandomNumber, y: RandomNumber, width: RandomNumber, height: RandomNumber);
			}
		}

		[Test]
		public void Draw_StoneTile()
		{
			for (var i = 0; i < 20; i++)
			{
				var tile = TileFactory.GetTile(TileType.Stone);
				tile.Draw(_graphics, x: RandomNumber, y: RandomNumber, width: RandomNumber, height: RandomNumber);
			}
		}

		private int RandomNumber => _rand.Next(100);
	}
}