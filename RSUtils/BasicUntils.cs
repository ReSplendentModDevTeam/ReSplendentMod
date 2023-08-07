
using ReSplendent.NPCs;
using ReSplendent.Projectiles;

namespace ReSplendent.RSUtils
{
    public static class BasicUntils
    {
        public static ReSplendentPlayer RS(this Player player) => player.GetModPlayer<ReSplendentPlayer>();
        public static RSGlobalNPC RS(this NPC npc) => npc.GetGlobalNPC<RSGlobalNPC>();
        public static RSGlobalProjectile Global(this Projectile proj) => proj.GetGlobalProjectile<RSGlobalProjectile>();

    }
}
