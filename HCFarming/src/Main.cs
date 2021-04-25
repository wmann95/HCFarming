using HCFarming.src;
using HCFarming.src.gui;
using HCFarming.src.rooms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HCFarming
{
	public class Main : Game
	{
		private GraphicsDeviceManager graphics;
		private Rendering renderer;
		private RoomManager roomManager;
		private GUIManager guiManager;

		public Main()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;

		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here
			roomManager = new RoomManager();
			guiManager = new GUIManager();
			renderer = new Rendering(graphics.GraphicsDevice);

			base.Initialize();
		}

		protected override void LoadContent()
		{

			// TODO: use this.Content to load your game content here
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			if (Keyboard.GetState().IsKeyDown(Keys.Space)) roomManager.MoveRoom(RoomLibrary.farm);

			// TODO: Add your update logic here

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
