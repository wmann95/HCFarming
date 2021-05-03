using HCFarming.src;
using HCFarming.src.gui;
using HCFarming.src.rooms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace HCFarming
{
	public class Main : Game
	{
		private GraphicsDeviceManager graphics;
		private Rendering renderer;
		private RoomManager roomManager;
		private GUIManager guiManager;

		public static ContentManager content;

		public Main()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;

			content = Content;
		}

		protected override void Initialize()
		{
			guiManager = new GUIManager();
			renderer = new Rendering(graphics.GraphicsDevice);
			roomManager = new RoomManager();


			base.Initialize();
		}

		protected override void LoadContent()
		{

		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			//if (Keyboard.GetState().IsKeyDown(Keys.Space)) roomManager.MoveRoom(RoomLibrary.farm);

			InputManager.Update();
			GUIManager.Update();

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(RoomManager.currentRoom.backgroundColor);

			renderer.Draw(gameTime);

			base.Draw(gameTime);
		}
	}
}
