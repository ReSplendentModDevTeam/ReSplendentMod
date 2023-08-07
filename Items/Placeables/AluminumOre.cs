
namespace ReSplendent.Items.Placeables
{
    public class AluminumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 100;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
            ItemID.Sets.OreDropsFromSlime[Type] = (3, 13);
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.AluminumOreTile>());
            Item.width = 12;
            Item.height = 12;
            Item.value = 75;
        }
    }
}