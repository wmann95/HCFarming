using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.gui
{
	abstract class GUI : MouseListener
	{

		public Vector2 position { get; private set; }

		public GUI()
		{
			InputManager.RegisterListener(this);
		}

		public void onDraw()
		{

		}

		public void Update()
		{
		}

		public abstract void OnMouseDown(MouseListener.MouseButton button);

		public abstract void OnMouseUp(MouseListener.MouseButton button);

		public abstract void OnMouseClicked(MouseListener.MouseButton button);
	}
}
