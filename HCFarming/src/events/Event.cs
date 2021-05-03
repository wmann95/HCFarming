using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCFarming.src.events
{
	class Event
	{

		private static List<MouseEvent> mouseEvents = new List<MouseEvent>();

		public Event()
		{

		}

		public static void RegisterEvent<Event>(Event e)
		{
			if(e is MouseEvent)
			{
				mouseEvents.Add(e as MouseEvent);
			}

		}

	}
	
	public class MouseEvent
	{

		public enum Button { Left, Middle, Right }
		public Button MouseButton { get; private set; }
		public Point Position { get; private set; }

		public MouseEvent(Button button, int xPos, int yPos)
		{
			MouseButton = button;
			Position = new Point(xPos, yPos);
		}

	}



}
