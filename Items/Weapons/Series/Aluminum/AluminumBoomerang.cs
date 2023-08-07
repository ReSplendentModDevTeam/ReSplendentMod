
using ReSplendent.Items.Placeables;
using ReSplendent.Projectiles.Aluminum;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumBoomerang : ModItem
    {

        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.damage = 14;
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 1;
            Item.value = 228;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item7;
            Item.autoReuse = true;
            Item.crit = 0;
            Item.scale = 1f;
            Item.useTurn = true;
            Item.shoot = ModContent.ProjectileType<AluminumBoomerangProj>();
            Item.shootSpeed = 8f;
            Item.noUseGraphic = true;
            Item.noMelee = true;
        }
        public override bool CanUseItem(Player player)
        {
            if (Main.LocalPlayer.ownedProjectileCounts[ModContent.ProjectileType<AluminumBoomerangProj>()] >= 1)
            {
                return false;
            }
            return true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 15);
            recipe.AddIngredient(ItemID.TinOre, 15);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}