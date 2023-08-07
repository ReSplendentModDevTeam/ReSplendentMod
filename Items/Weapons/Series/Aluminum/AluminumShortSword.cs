
using ReSplendent.Items.Placeables;
using ReSplendent.Projectiles.Aluminum;

namespace ReSplendent.Items.Weapons.Series.Aluminum
{
    public class AluminumShortSword : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Aluminumproducts.hjson file.

        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.damage = 9;
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.knockBack = 3;
            Item.value = 150;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 0;
            Item.scale = 1;
            Item.useTurn = true;
            Item.shoot = ModContent.ProjectileType<AluminumShortSwordProj>();
            Item.shootSpeed = 2.1f;
            Item.noUseGraphic = true;
            Item.noMelee = true;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.DryadsWardDebuff, 120);
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