using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HCFarming.src
{
	public static class InputManager
	{
		//Mouse
		static MouseState oldState;

		private static List<MouseListener> mouseListeners = new List<MouseListener>();
		private static List<KeyListener> keyListeners = new List<KeyListener>();

		public static void Update()
		{
			if (oldState == null)
			{
				oldState = Mouse.GetState();
				return;
			}

			MouseState newState = Mouse.GetState();

			//check if left mousebutton was pressed, then released.
			if (newState.LeftButton == ButtonState.Released && oldState.LeftButton == ButtonState.Pressed)
			{
				foreach (MouseListener m in mouseListeners)
				{
					m.OnMouseClicked(MouseListener.MouseButton.Left);
				}
			}
			//check if middle mousebutton was pressed, then released.
			if (newState.MiddleButton == ButtonState.Released && oldState.MiddleButton == ButtonState.Pressed)
			{
				foreach (MouseListener m in mouseListeners)
				{
					m.OnMouseClicked(MouseListener.MouseButton.Middle);
				}
			}
			//check if right mousebutton was pressed, then released.
			if (newState.RightButton == ButtonState.Released && oldState.RightButton == ButtonState.Pressed)
			{
				foreach (MouseListener m in mouseListeners)
				{
					m.OnMouseClicked(MouseListener.MouseButton.Right);
				}
			}


			oldState = Mouse.GetState();
		}

		public static void RegisterListener<T>(T t)
		{
			if(t is MouseListener)
			{
				mouseListeners.Add(t as MouseListener);
				//Debug.Write("Registered MouseListener");
			}
			if(t is KeyListener)
			{
				keyListeners.Add(t as KeyListener);
			}
		}

	}
	public interface MouseListener
	{
		enum MouseButton { Left, Middle, Right}
		void OnMouseDown(MouseButton button);
		void OnMouseUp(MouseButton button);
		void OnMouseClicked(MouseButton button);
	}
	public interface KeyListener
	{

	}
}
