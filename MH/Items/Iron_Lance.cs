using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MH.Projectiles;

namespace MH.Items
{
    public class Iron_Lance : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Iron Lance";
            item.toolTip = "A trusty old lance";
            item.damage = 9;
            item.useStyle = 5;
            item.useAnimation = 37;
            item.useTime = 30;
            item.shootSpeed = 18f;
            item.knockBack = 6.5f;
            item.width = 32;
            item.height = 32;
            item.scale = 1f;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType<Iron_Lance_Projectile>();
            item.value = 1000;
            item.noMelee = true; // Important because the spear is acutally a projectile instead of an item. This prevents the melee hitbox of this item.
            item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
            item.melee = true;
            item.autoReuse = false; // Most spears dont autoReuse, but it's possible
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1; // This is to ensure the spear doesn't bug out when using autoReuse = true
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.CopperBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
