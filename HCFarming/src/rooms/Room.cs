using HCFarming.src.tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.rooms
{
	abstract class Room
	{

		public Color backgroundColor { get; protected set; }
		public Tile[][] tiles { get; private set; }
		//public TileSet tileSet {get; private set;}

		public readonly string RoomName;

		public Room(string roomName)
		{
			int width = 100;
			int height = 100;

			backgroundColor = Color.CornflowerBlue;

			RoomName = roomName;

			tiles = new Tile[height][];


			for(int i = 0; i < height; i++)
			{
				tiles[i] = new Tile[width];
			}

			RoomManager.RegisterRoom(this);
		}

		/// <summary>
		/// Sets a particular x and y position in the room's tile array. Returns false if the tile is already taken. If you wish to override the tile, use the alternate SetTile function, SetTile(x, y, tile, true/false)
		/// </summary>
		/// <param name="xPos"></param>
		/// <param name="yPos"></param>
		/// <param name="tile"></param>
		/// <returns></returns>
		protected bool SetTile(int xPos, int yPos, Tile tile)
		{
			if(tiles[yPos][xPos] == null)
			{
				tiles[yPos][xPos] = tile;
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
		protected bool SetTile(int xPos, int yPos, Tile tile, bool rewrite)
		{
			if (rewrite)
			{
				tiles[yPos][xPos] = tile;
				return true;
			}

			return SetTile(xPos, yPos, tile);
		}

		public abstract void DrawTiles(SpriteBatch batch);

		public abstract void DrawEntities(SpriteBatch batch);

		public abstract void DrawGUI(SpriteBatch batch);

	}
}
