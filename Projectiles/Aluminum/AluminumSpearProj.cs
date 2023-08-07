

namespace ReSplendent.Projectiles.Aluminum
{
    public class AluminumSpearProj : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.penetrate = 2;
            Projectile.ignoreWater = true;
            Projectile.timeLeft = 180;
            Projectile.DamageType = DamageClass.Melee;
        }
        public bool Sticking
        {
            get { return Projectile.ai[0] != 0; }
            set { Projectile.ai[0] = value ? 1 : 0; }
        }
        public int TargetWho
        {
            get { return (int)Projectile.ai[1]; }
            set { Projectile.ai[1] = value; }
        }
        public override void AI()
        {
            if (Sticking)
            {
                NPC target = Main.npc[TargetWho];
                if (!target.active)
                {
                    Projectile.Kill();
                    return;
                }
                Projectile.velocity = target.velocity;
            }
            else
            {
                Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.TwoPi / 8f;
            }
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            Sticking = true;
            TargetWho = target.whoAmI;
            Projectile.timeLeft = 300;
            target.AddBuff(36, 360);
        }
        public override bool? CanDamage()
        {
            return !Sticking;
        }
        public override bool PreDraw(ref Color lightColor)
        {
            Texture2D tex = TextureAssets.Projectile[Type].Value;
            Main.spriteBatch.Draw(tex, Projectile.Center - Main.screenPosition, null, lightColor * Projectile.Opacity,
                Projectile.rotation, tex.Size() / 2f, Projectile.scale,
                Math.Abs(Projectile.rotation) < Math.PI / 2f ? 0 : SpriteEffects.FlipVertically, 0f);
            return false;

        }
    }
}