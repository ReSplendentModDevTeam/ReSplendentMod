

namespace ReSplendent.Items.BossLoot.KingSlime
{
    [AutoloadEquip(EquipType.Wings)]
    public class SlimyWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            // These wings use the same values as the solar wings
            // Fly time: 180 ticks = 3 seconds
            // Fly speed: 9
            // Acceleration multiplier: 2.5
            ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(38, 2.67f, 1.5f); //no 38.4 flytime
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 2, 30, 0);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 1.1f; // Falling glide speed
            ascentWhenRising = 0.1f; // Rising speed
            maxCanAscendMultiplier = 0.8f;
            maxAscentMultiplier = 1.5f;
            constantAscend = 0.135f;
        }
    }
}
