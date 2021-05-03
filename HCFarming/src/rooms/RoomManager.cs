using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src.rooms
{
	class RoomManager
	{

		private static Dictionary<string, Room> roomLib = new Dictionary<string, Room>();

		public static Room currentRoom { get; private set; }

		public RoomManager()
		{

			currentRoom = RoomLibrary.mainMenu;
			//currentRoom = RoomLibrary.farm;
		}

		public static bool MoveRoom(Room room)
		{
			if (currentRoom == room)
			{
				return false;
			}

			if (roomLib.ContainsKey(room.RoomName))
			{
				currentRoom = roomLib[room.RoomName];

				Debug.WriteLine(String.Format("Moving to Room:{0}", room.RoomName));

				return true;
			}

			Debug.WriteLine(String.Format("Could not find Room:${0}", room.RoomName));
			return false;
		}

		public static bool RegisterRoom(Room room)
		{
			if (roomLib.ContainsKey(room.RoomName))
			{
				Debug.WriteLine(String.Format("$Room:{0} has already been registered!", room.RoomName));
				return false;
			}

			roomLib.Add(room.RoomName, room);
			return true;
		}

	}
}
