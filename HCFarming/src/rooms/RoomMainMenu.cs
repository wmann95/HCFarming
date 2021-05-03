using HCFarming.src.gui;
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
			BackgroundColor = Color.Green;
		}

		public override void DrawEntities(SpriteBatch batch)
		{}

		public new void DrawGUI(SpriteBatch batch)
		{
			base.DrawGUI(batch);
		}

		public new void DrawTiles(SpriteBatch batch)
		{}

		public override void Load()
		{

			GUIButton button = new GUIButton(this, "textures/gui/MainMenu/StartGameButton", new Vector2(Rendering.device.Viewport.Width/2, Rendering.device.Viewport.Height / 2), new Vector2(256/2, 32/2), 1f, 0f, 0f);

		}

		protected override string GetTilesetTexture()
		{
			return null;
		}
	}
}
