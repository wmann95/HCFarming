using HCFarming.src.events;
using HCFarming.src.input;
using HCFarming.src.rooms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.gui
{
	class GUIButton : GUI
	{

		public GUIButton(Room room, string texture, Vector2 pos, Vector2 o, float s, float r, float z) : base(room, texture, pos, o, s, r, z)
		{

		}

		public new void Draw(SpriteBatch batch)
		{
			base.Draw(batch);
		}

		public override void OnMouseClicked(MouseEvent e)
		{
			//Debug.WriteLine(String.Format("Mouse Pos: {0}; Rect: {1}", e.Position, bounds));

			if (InputHelper.isPointInBounds(e.Position, bounds))
			{
				RoomManager.MoveRoom(RoomLibrary.farm);
			}
		}

		public override void OnMouseDown(MouseEvent e)
		{
			
		}

		public override void OnMouseUp(MouseEvent e)
		{
			
		}
	}
}
