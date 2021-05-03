using HCFarming.src.events;
using HCFarming.src.rooms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.gui
{
	abstract class GUI : MouseListener
	{

		public Vector2 position { get; private set; }
		public Vector2 center { get; private set; }
		public float scale { get; private set; }
		public float rotation { get; private set; }
		public float zDepth { get; private set; }
		public Texture2D guiTexture { get; private set; }
		public Rectangle bounds { get; private set; }

		public GUI(Room room, string texture, Vector2 pos, Vector2 o, float s, float r, float z)
		{

			position = pos;
			center = o;
			scale = s;
			rotation = r;
			zDepth = z;


			if (texture != null)
			{
				guiTexture = Main.content.Load<Texture2D>(texture);
				bounds = new Rectangle((int)(pos.X - guiTexture.Width / 2), (int)(pos.Y - guiTexture.Height / 2), guiTexture.Width, guiTexture.Height);
			}
			else
			{
				bounds = new Rectangle((int)pos.X, (int)pos.Y, 0, 0);
			}
			



			InputManager.RegisterListener(this);
			GUIManager.RegisterGUI(this, room);
			
		}

		public void Draw(SpriteBatch batch)
		{
			if (guiTexture != null)
			{
				batch.Draw(guiTexture, position, null, Color.White, rotation, center, scale, SpriteEffects.None, zDepth);
			}
		}

		public void Update()
		{
		}

		public abstract void OnMouseDown(MouseEvent e);

		public abstract void OnMouseUp(MouseEvent e);

		public abstract void OnMouseClicked(MouseEvent e);
	}
}
