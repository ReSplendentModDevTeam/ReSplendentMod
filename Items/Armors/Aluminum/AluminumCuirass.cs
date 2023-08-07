using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ReSplendent.Items.Placeables;

namespace ReSplendent.Items.Armors.Aluminum
{
    [AutoloadEquip(EquipType.Body)]
    public class AluminumCuirass : ModItem
    {
        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.width = 18;
            Item.height = 18;
            Item.value = 400;
            Item.rare = 2;
            Item.defense = 2;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 25);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}