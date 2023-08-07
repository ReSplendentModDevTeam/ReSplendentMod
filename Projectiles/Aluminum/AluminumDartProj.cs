
using Terraria.Audio;
using Terraria.Graphics.CameraModifiers;
using ReSplendent.Items.Weapons.Series.Aluminum;

namespace ReSplendent.Projectiles.Aluminum
{
    public class AluminumDartProj : ModProjectile
    {
        public bool IsStickingToTarget
        {
            get => Projectile.ai[0] == 1f;
            set => Projectile.ai[0] = value ? 1f : 0f;
        }
        public int TargetWhoAmI
        {
            get => (int)Projectile.ai[1];
            set => Projectile.ai[1] = value;
        }
        public int GravityDelayTimer
        {
            get => (int)Projectile.ai[2];
            set => Projectile.ai[2] = value;
        }
        public float StickTimer
        {
            get => Projectile.localAI[0];
            set => Projectile.localAI[0] = value;
        }

        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.alpha = 0;
            Projectile.light = 0.5f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
        }
        private const int GravityDelay = 35;

        Player player => Main.player[Projectile.owner];
        public override void AI()
        {
            int d = player.ownedProjectileCounts[ModContent.ProjectileType<AluminumDartProj>()];

            if (d <= 30)
            {
                if (Projectile.ai[0] >= 20)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        Vector2 plrToMouse = Main.MouseWorld - Projectile.Center;
                        float r = (float)Math.Atan2(plrToMouse.Y, plrToMouse.X);
                        float r2 = r + i * MathHelper.Pi / 36f;
                        Vector2 shootVel = -(r2.ToRotationVector2() * 10);
                        Projectile.NewProjectile(Projectile.GetSource_FromAI(), Projectile.Center, shootVel,
            ModContent.ProjectileType<AluminumDartProj>(), (int)(7 * 0.5), 5f, Projectile.owner);
                        Projectile.ai[0] = 0;
                    }
                }
                Projectile.ai[0]++;
            }

            GravityDelayTimer++;
            if (GravityDelayTimer >= GravityDelay)
            {
                GravityDelayTimer = GravityDelay;
                Projectile.velocity.X *= 0.98f;
                Projectile.velocity.Y += 0.35f;
            }
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
            if (Main.rand.NextBool(3))
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Electric, Projectile.velocity.X * .2f, Projectile.velocity.Y * .2f, 200, Scale: 1.2f);
                dust.velocity += Projectile.velocity * 0.3f;
                dust.velocity *= 0.2f;
            }
            if (Main.rand.NextBool(4))
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Electric,
                    0, 0, 254, Scale: 0.3f);
                dust.velocity += Projectile.velocity * 0.5f;
                dust.velocity *= 0.5f;
            }
        }
        public override void Kill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Dig, Projectile.position);


            Vector2 usePos = Projectile.position;
            Vector2 rotationVector = (Projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
            usePos += rotationVector * 16f;
            for (int i = 0; i < 20; i++)
            {
                Dust dust = Dust.NewDustDirect(usePos, Projectile.width, Projectile.height, DustID.Tin);
                dust.position = (dust.position + Projectile.Center) / 2f;
                dust.velocity += rotationVector * 2f;
                dust.velocity *= 0.5f;
                dust.noGravity = true;
                usePos -= rotationVector * 8f;
            }
            if (Projectile.owner == Main.myPlayer)
            {
                int item = 0;
                if (Main.rand.NextBool(18))
                {
                    item = Item.NewItem(Projectile.GetSource_DropAsItem(), Projectile.getRect(), ModContent.ItemType<AluminumDart>());
                }
                if (Main.netMode == NetmodeID.MultiplayerClient && item >= 0)
                {
                    NetMessage.SendData(MessageID.SyncItem, -1, -1, null, item, 1f);
                }
            }

        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            PunchCameraModifier modifier = new PunchCameraModifier(player.Center, (Main.rand.NextFloat() * ((float)Math.PI * 2f)).ToRotationVector2(), 2f, 5f, 5, 1000f, FullName);
            Main.instance.CameraModifiers.Add(modifier);
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough, ref Vector2 hitboxCenterFrac)
        {
            width = height = 10;
            return true;
        }
    }
}
