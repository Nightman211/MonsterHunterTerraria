using Terraria.ModLoader;

namespace MH
{
	class MH : Mod
	{
		public MH()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
