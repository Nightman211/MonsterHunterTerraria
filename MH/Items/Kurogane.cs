using Terraria.ID;
using Terraria.ModLoader;

namespace MH.Items
{
    public class Kurogane : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Kurogane";
            item.damage = 1;
            item.melee = true;
            item.width = 60;
            item.height = 60;
            item.toolTip = "A trusty, old, and effective, yet very crude hammer.";
            item.useTime = 75;
            item.useAnimation = 75;
            item.useStyle = 2;
            item.knockBack = 20;
            item.value = 1000;
            item.rare = 6;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
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
