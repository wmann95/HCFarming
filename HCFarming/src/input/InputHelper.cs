using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.input
{
	class InputHelper
	{

		public static bool isPointInBounds(Point p, Rectangle rect)
		{

			Debug.WriteLine(String.Format("Mouse Pos: {0}; Rect: {1}", p, rect));

			return rect.Contains(p);
		}

	}
}
