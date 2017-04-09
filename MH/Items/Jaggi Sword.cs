using Terraria.ID;
using Terraria.ModLoader;

namespace MH.Items
{
	public class Jaggi_Sword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Jaggi Sword";
			item.damage = 1000000000;
			item.melee = true;
			item.width = 40;
			item.height = 400;
			item.toolTip = "This is a modded sword.";
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
