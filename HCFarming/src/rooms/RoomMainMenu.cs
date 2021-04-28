using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.rooms
{
	class RoomMainMenu : Room 
	{

		public RoomMainMenu() : base("mainMenu")
		{
			backgroundColor = Color.White;
		}

		public override void DrawEntities(SpriteBatch batch)
		{}

		public override void DrawGUI(SpriteBatch batch)
		{
			
		}

		public new void DrawTiles(SpriteBatch batch)
		{}

		public override void Load()
		{
		}

		protected override string GetTilesetTexture()
		{
			return null;
		}
	}
}
