namespace ReSplendent.NPCs.GNPCs
{
    public class RSDamageOverTimeGNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        public bool ThermitBurningDebuff = false;
        public int ThermitBurningDebuffCounter;
        public override void ResetEffects(NPC npc)
        {
            if(!ThermitBurningDebuff) 
            {
                ThermitBurningDebuffCounter = 0;
            }
            else
            {
                ThermitBurningDebuffCounter++;
            }
            ThermitBurningDebuff = false;
            
            
        }
        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (ThermitBurningDebuff)
            {
                Vector2 dustPos = npc.Center + (npc.position - npc.Center).RotatedByRandom(MathHelper.TwoPi) * Main.rand.NextFloat(0, 1f);
                Dust.NewDustPerfect(dustPos, DustID.Fireworks, new Vector2(Main.rand.NextFloat(-1.5f, 1.5f), Main.rand.NextFloat(-0.2f, 1f)), 100, default, Main.rand.NextFloat(0.4F, 1.8F));
            }
            //base.DrawEffects(npc, ref drawColor);
        }
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (ThermitBurningDebuff)
            {
                damage = ThermitBurningDamage();
                npc.lifeRegen -= damage;
            }
        }

        public int ThermitBurningDamage()
        {
            float w = (ThermitBurningDebuffCounter > 300f ? ThermitBurningDebuffCounter : 300f) / 300f;
            return (int)MathHelper.Lerp(16, 48, w);
        }
    }
}
