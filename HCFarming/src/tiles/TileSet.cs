using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.tiles
{
	class TileSet
	{
		private int tileSize = 32;
		private readonly Texture2D tilesetTexture;

		private Rectangle[][] textureList;

		public TileSet(string textureName)
		{
			tilesetTexture = Texture2D.FromFile(Rendering.device, textureName);

			int xCount = tilesetTexture.Width / 32;
			int yCount = tilesetTexture.Height / 32;

			textureList = new Rectangle[yCount][];

			for(int i = 0; i < yCount; i++)
			{
				textureList[i] = new Rectangle[xCount];

				for (int j = 0; j < xCount; j++)
				{

					Rectangle rect = new Rectangle(j * tileSize, i * tileSize, tileSize, tileSize);

				}
			}
		}



	}
}
