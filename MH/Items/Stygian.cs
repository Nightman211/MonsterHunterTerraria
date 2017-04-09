using Terraria.ID;
using Terraria.ModLoader;

namespace MH.Items
{
	public class Stygian : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Stygian";
			item.damage = 100;
			item.melee = true;
			item.width = 90;
			item.height = 90;
			item.toolTip = "This is a modded sword.";
			item.useTime = 60;
			item.useAnimation = 60;
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
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
