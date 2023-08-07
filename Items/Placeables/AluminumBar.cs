using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReSplendent.Items.Placeables
{
    public class AluminumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.AluminumBarTile>());
            Item.width = 20;
            Item.height = 20;
            Item.value = 225;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<AluminumOre>(3)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}
