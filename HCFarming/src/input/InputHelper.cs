using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.input
{
	class InputHelper
	{

		public static bool isPointInBounds(Point p, Rectangle rect)
		{
			//(e.xPosition >= position.X - guiTexture.Width / 2 && e.xPosition <= position.X + guiTexture.Width / 2) && (e.yPosition >= position.Y - guiTexture.Height / 2 && e.yPosition <= position.Y + guiTexture.Height / 2)
			return rect.Contains(p);
		}

	}
}
