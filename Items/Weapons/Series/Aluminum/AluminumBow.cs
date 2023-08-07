
using ReSplendent.Items.Placeables;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumBow : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Aluminumproducts.hjson file.

        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.damage = 9;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 27;
            Item.useAnimation = 27;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 0;
            Item.value = 175;
            Item.rare = 2;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.crit = 0;
            Item.scale = 1.3f;
            Item.useTurn = false;
            Item.shoot = 1;
            Item.shootSpeed = 6;
            Item.useAmmo = AmmoID.Arrow;
        }
        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.3f;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-0.05f, 0);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 6);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}