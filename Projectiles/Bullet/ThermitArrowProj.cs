
using ReSplendent.Buffs.DoTs;
using Terraria.Audio;
using Terraria.ID;

namespace ReSplendent.Projectiles.Bullet
{
    public class ThermitArrowProj : ModProjectile
    {
        //no tex
        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 8;// The height of projectile hitbox
            Projectile.aiStyle = ProjAIStyleID.Arrow;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.alpha = 0;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 0;

            AIType = ProjectileID.WoodenArrowFriendly;
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(ModContent.BuffType<ThermitBurning>(), 120);
        }
        
        public override void PostAI()
        {
            Projectile.rotation += (float)Math.PI;
        }
        
        public override bool PreDraw(ref Color lightColor)
        {

            Texture2D tex = TextureAssets.Projectile[Projectile.type].Value;
            Main.EntitySpriteDraw(tex, Projectile.Center - Main.screenPosition, new Rectangle(0, 0, tex.Width, tex.Height), Color.White,
                    Projectile.rotation, new Vector2(tex.Width / 2, tex.Height / 2), 1, SpriteEffects.None, 0f);

            return false;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }
    }
}
