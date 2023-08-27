using ReSplendent.Items.Placeables;
using ReSplendent.Projectiles.Aluminum;
using ReSplendent.Projectiles.Bullet;

namespace ReSplendent.Items.Bullets
{
    public class ThermitArrow : ModItem
    {
        // no tex
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 99;
        }
        public override void SetDefaults()
        {
            Item.damage = 6;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 22;
            Item.knockBack = 1.2f;
            Item.value = Item.sellPrice(0, 0, 1, 0);
            Item.rare = ItemRarityID.Green;
            Item.crit = 2;
            Item.maxStack = Item.CommonMaxStack;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<ThermitArrowProj>();
            Item.shootSpeed = 6f;
            Item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes() //真的不打算改改？三个铝锭就合成99个？
        {
            CreateRecipe(99)
                .AddIngredient<AluminumBar>(3)
                .AddIngredient(ItemID.MusketBall, 99)
                .AddIngredient(ItemID.FlowerofFire)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}