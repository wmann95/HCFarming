﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.rooms
{
	class RoomFarm : Room
	{



		public RoomFarm() : base("farm")
		{
			backgroundColor = Color.Black;

			for(int j = 0; j < tiles.Length; j++)
			{
				for(int i = 0; i < tiles[j].Length; i++)
				{
					SetTile(i, j, 0);
				}
			}


		}

		public override void DrawEntities(SpriteBatch batch)
		{
			
		}

		public override void DrawGUI(SpriteBatch batch)
		{

		}

		protected override string GetTilesetTexture()
		{
			return "textures/tilesets/FarmTileset1";
		}

		public override void Load(){}
	}
}
