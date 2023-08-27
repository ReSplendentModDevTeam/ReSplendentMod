
using ReSplendent.Projectiles.Magic;

namespace ReSplendent.Items.BossLoot.SlimeKing
{
    public class GelWand : ModItem
    {
        //no tex
        public override string Texture => "ReSplendent/Items/NoTexture";
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Magic;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.damage = 6;
            Item.mana = 2;
            Item.knockBack = 3;
            Item.useAnimation = Item.useTime = 6;
            Item.shootSpeed = 8.5f; // are you sure?
            Item.value = Item.sellPrice(0, 2, 10, 0);
            Item.shoot = ModContent.ProjectileType<GelWandProj>();
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int num = Main.rand.Next(3, 6);
            for(int i = 0; i <= num; i++)
            {
                Vector2 vel = velocity.RotatedBy(Main.rand.NextFloat(-MathHelper.Pi / 6, MathHelper.Pi / 6));
                Projectile.NewProjectile(source, position, vel, type, damage, knockback, player.whoAmI);
            }
            return false;
        }
        
    }
}
