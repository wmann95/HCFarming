using System;

namespace HCFarming
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			using (var game = new Main())
				game.Run();
		}
	}
}
