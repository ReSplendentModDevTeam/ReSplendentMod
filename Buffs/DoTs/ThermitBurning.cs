
using ReSplendent.NPCs.GNPCs;

namespace ReSplendent.Buffs.DoTs
{
    public class ThermitBurning : ModBuff
    {
        //no tex
        public override string Texture => "ReSplendent/Items/NoTexture";
        public override void SetStaticDefaults()
        {

        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<RSDamageOverTimeGNPC>().ThermitBurningDebuff = true;
        }
    }
}
