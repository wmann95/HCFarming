using HCFarming.src.rooms;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.gui
{
	class GUIManager
	{

		private static Dictionary<Room, List<GUI>> registeredGUIs = new Dictionary<Room, List<GUI>>();

		public static bool RegisterGUI(GUI gui, Room room)
		{
			Debug.WriteLine(String.Format("Trying to register GUI."));

			if (!registeredGUIs.ContainsKey(room))
			{
				registeredGUIs.Add(room, new List<GUI>()); // this is the first time the room is being registered, give it a new GUI list and add the gui to the list.
				registeredGUIs[room].Add(gui);
				return true;
			}
			else if(!registeredGUIs[room].Contains(gui)) // Not the first time this room has been registered, and isn't a duplicate.
			{
				registeredGUIs[room].Add(gui);
				return true;
			}
			else
			{
				return false;
			}
		}

		public static void Update()
		{
			if (!registeredGUIs.ContainsKey(RoomManager.currentRoom)) return;

			List<GUI> guis = registeredGUIs[RoomManager.currentRoom];


			for (int i = 0; i < guis.Count; i++)
			{
				guis[i].Update();
			}

		}
		public static void Draw(SpriteBatch batch)
		{
			if (!registeredGUIs.ContainsKey(RoomManager.currentRoom)) return;

			List<GUI> guis = registeredGUIs[RoomManager.currentRoom];

			if (guis == null) return;

			for (int i = 0; i < guis.Count; i++)
			{
				guis[i].Draw(batch);
			}

		}

	}
}
