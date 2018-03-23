using System.Collections.Generic;
using FlyweightPattern.Model;

namespace FlyweightPattern.Library
{
	public static class TileFactory
	{
		private static readonly Dictionary<string, ITile> Tiles = new Dictionary<string, ITile>();

		public static ITile GetTile(TileType type)
		{
			switch (type)
			{
				case TileType.Ceramic:
					if (!Tiles.ContainsKey(TileType.Ceramic.ToString()))
						Tiles[TileType.Ceramic.ToString()] = new CeramicTile();
					return Tiles[TileType.Ceramic.ToString()];
				case TileType.Stone:
					if (!Tiles.ContainsKey(TileType.Stone.ToString()))
						Tiles[TileType.Stone.ToString()] = new StoneTile();
					return Tiles[TileType.Stone.ToString()];
			}

			return null;
		}
	}
}