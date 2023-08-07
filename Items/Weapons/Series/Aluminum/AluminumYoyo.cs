
using ReSplendent.Items.Placeables;
using ReSplendent.Projectiles.Aluminum;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumYoyo : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.UseSound = SoundID.Item1;
            Item.damage = 9;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.knockBack = 2f;
            Item.crit = 29;
            Item.channel = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = 147;
            Item.shoot = ModContent.ProjectileType<AluminumYoyoProj>();
            Item.shootSpeed = 30f;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 4);
            recipe.AddIngredient(ItemID.Cobweb, 8);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}
