
using ReSplendent.Items.Placeables;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumDart : ModItem
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
            Item.maxStack = 9999;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 25;
            Item.useTime = 25;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.damage = 7;
            Item.knockBack = 0;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Ranged;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<Projectiles.Aluminum.AluminumDartProj>();
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(50);
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 15);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}