
namespace ReSplendent.Projectiles.Aluminum
{
    public class AluminumBoomerangProj : ModProjectile
    {
        public const int TotalDuration = 100;
        public float CollisionWidth => 10f * Projectile.scale;
        public override void SetDefaults()
        {
            Projectile.Size = new Vector2(16);
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.scale = 1f;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 500;//
        }
        public override bool ShouldUpdatePosition()
        {
            return true;
        }
        public override void AI()
        {
            Projectile.ai[0]++;
            Player player = Main.player[Projectile.owner];
            if (Main.rand.NextBool(5))
            {
                int choice = Main.rand.Next(3);
                if (choice == 0)
                {
                    choice = 15;
                }
                else if (choice == 1)
                {
                    choice = 57;
                }
                else
                {
                    choice = 58;
                }
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, choice, Projectile.velocity.X * 0.25f, Projectile.velocity.Y * 0.25f, 150, default, 0.7f);
            }
            Projectile.rotation += MathHelper.Pi / 10;//
            if (Projectile.ai[0] >= 60)
            {
                Projectile.velocity = Vector2.Normalize(player.Center - Projectile.Center) * 6f;
            }

            if (Vector2.Distance(player.Center, Projectile.Center) < 32 && Projectile.ai[0] >= 50)//
            {
                Projectile.Kill();
            }
        }
    }
}