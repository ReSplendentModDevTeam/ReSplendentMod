

namespace ReSplendent.Projectiles.Magic
{
    public class GelWandProj : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.penetrate = 1;
            Projectile.aiStyle = -1;
            Projectile.extraUpdates = 1;
            Projectile.friendly = true;
            Projectile.hostile = false;
        }
        public override void AI()
        {
            Dust.NewDustPerfect(Projectile.Center, DustID.WaterCandle, null, 100, default, Main.rand.NextFloat(0.7f, 1.4f));
            Projectile.velocity.Y += 0.1f;
            base.AI();
        }
        public override void Kill(int timeLeft)
        {
            for(int i = 0; i < 5; i++)
                Dust.NewDustPerfect(Projectile.Center, DustID.WaterCandle, new Vector2(Main.rand.NextFloat(-2f,2f), Main.rand.NextFloat(-1f, 1f)), 100, default, Main.rand.NextFloat(0.9f, 1.8f));
        }
        
    }
}
