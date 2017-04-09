using Terraria.ID;
using Terraria.ModLoader;

namespace MH.Items
{
    public class Stahlfakt : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Stahlfakt";
            item.damage = 55;
            item.melee = true;
            item.width = 20;
            item.height = 65;
            item.toolTip = "An evil accursed sword that sends foes hellward.";
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1000;
            item.rare = 6;
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
