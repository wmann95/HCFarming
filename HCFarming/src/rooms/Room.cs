using HCFarming.src.gui;
using HCFarming.src.tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.rooms
{
	abstract class Room
	{

		public Color backgroundColor { get; protected set; }
		public int[][] tiles { get; private set; }
		public TileSet tileSet {get; private set;}

		public readonly string RoomName;

		public Room(string roomName)
		{
			int width = 100;
			int height = 100;

			backgroundColor = Color.CornflowerBlue;

			RoomName = roomName;

			tiles = new int[height][];


			for(int i = 0; i < height; i++)
			{
				tiles[i] = new int[width];
				
				for(int j = 0; j < width; j++)
				{
					tiles[i][j] = -1;
				}
			}

			Load();

			if (GetTilesetTexture() != null)
			{
				tileSet = new TileSet(GetTilesetTexture());
			}

			RoomManager.RegisterRoom(this);
		}

		public abstract void Load();

		protected abstract string GetTilesetTexture();

		/// <summary>
		/// Sets a particular x and y position in the room's tile array. Returns false if the tile is already taken. If you wish to override the tile, use the alternate SetTile function, SetTile(x, y, tile, true/false)
		/// </summary>
		/// <param name="xPos"></param>
		/// <param name="yPos"></param>
		/// <param name="tile"></param>
		/// <returns></returns>
		protected bool SetTile(int xPos, int yPos, int tileIndex)
		{
			if(tiles[yPos][xPos] == -1)
			{
				tiles[yPos][xPos] = tileIndex;
				return true;
			}

			return false;
		}

		/// <summary>
		/// Sets a particular x and y position in the room's tile array. If rewrite is true, it will overwrite the tile, otherwise it will do the same as SetTile().
		/// </summary>
		/// <param name="xPos"></param>
		/// <param name="yPos"></param>
		/// <param name="tile"></param>
		/// <param name="rewrite"></param>
		/// <returns></returns>
		protected bool SetTile(int xPos, int yPos, int tileIndex, bool rewrite)
		{
			if (rewrite)
			{
				tiles[yPos][xPos] = tileIndex;
				return true;
			}

			return SetTile(xPos, yPos, tileIndex);
		}

		public void DrawTiles(SpriteBatch batch)
		{
			if (tileSet == null) return;

			for(int y = 0; y < tiles.Length; y++)
			{
				for(int x = 0; x < tiles[y].Length; x++)
				{

					if (tiles[y][x] == -1) continue;

					batch.Draw(tileSet.tilesetTexture, new Rectangle((int)(x * tileSet.tileSize), (int)(y * tileSet.tileSize), tileSet.tileSize, tileSet.tileSize), tileSet.textureList[tiles[y][x]], Color.White);

				}
			}

		}

		public abstract void DrawEntities(SpriteBatch batch);

		public void DrawGUI(SpriteBatch batch)
		{
			GUIManager.Draw(batch);
		}

	}
}
