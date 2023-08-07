
using ReSplendent.Items.Placeables;
using ReSplendent.Projectiles.Aluminum;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumSpear : ModItem
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Green;
            Item.value = 2998;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.damage = 12;
            Item.knockBack = 3f;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Melee;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<AluminumSpearProj>();
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 7);
            recipe.AddIngredient(ItemID.TinOre, 12);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}