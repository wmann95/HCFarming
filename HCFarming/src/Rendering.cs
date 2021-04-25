using HCFarming.src.rooms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src
{
	class Rendering
	{
		private SpriteBatch floorSB;
		private SpriteBatch entitySB;
		private SpriteBatch guiSB;


		public static GraphicsDevice device { get; private set; }

		public Rendering(GraphicsDevice gd)
		{
			device = gd;

			floorSB = new SpriteBatch(device);
			entitySB = new SpriteBatch(device);
			guiSB = new SpriteBatch(device);

		}

		public void Draw(GameTime gameTime)
		{

			Room currentRoom = RoomManager.currentRoom;

			//draw floor first
			floorSB.Begin();

			currentRoom.DrawTiles(floorSB);

			floorSB.End();

			//next, the entities: Trees, crops, people, etc.
			entitySB.Begin();

			currentRoom.DrawEntities(entitySB);

			entitySB.End();

			//finally, the GUI, as it should be on top of everything.
			guiSB.Begin();

			currentRoom.DrawGUI(guiSB);

			guiSB.End();
		}
	}
}
