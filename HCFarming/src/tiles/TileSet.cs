using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.tiles
{
	class TileSet
	{
		public readonly int tileSize = 32;
		public readonly Texture2D tilesetTexture;

		private int xCount, yCount;

		public Rectangle[] textureList { get; private set; }

		public TileSet(string textureName)
		{

			tilesetTexture = Main.content.Load<Texture2D>(textureName);

			xCount = tilesetTexture.Width / tileSize;
			yCount = tilesetTexture.Height / tileSize;

			textureList = new Rectangle[xCount * yCount];

			for(int i = 0; i < xCount * yCount; i++)
			{

				int x = (int)(i % xCount);
				int y = (int)(i / xCount);

				textureList[i] = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

			}
		}

	}
}
