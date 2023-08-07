
using ReSplendent.Items.Placeables;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumBroadSword : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Aluminumproducts.hjson file.

        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.damage = 11;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 4;
            Item.value = 200;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 0;
            Item.scale = 1.5f;

        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.DryadsWardDebuff, 120);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 8);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}