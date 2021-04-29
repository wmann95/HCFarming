using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.gui
{
	class GUIButton : GUI
	{
		public override void OnMouseClicked(MouseListener.MouseButton button)
		{
			Debug.WriteLine(String.Format("{0} Button Pressed", button));
		}

		public override void OnMouseDown(MouseListener.MouseButton button)
		{
			
		}

		public override void OnMouseUp(MouseListener.MouseButton button)
		{
			
		}
	}
}
