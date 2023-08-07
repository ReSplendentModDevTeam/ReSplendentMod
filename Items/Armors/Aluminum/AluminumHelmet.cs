using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ReSplendent.Items.Placeables;

namespace ReSplendent.Items.Armors.Aluminum
{
    [AutoloadEquip(EquipType.Head)]
    public class AluminumHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.width = 18;
            Item.height = 18;
            Item.value = 300;
            Item.rare = 2;
            Item.defense = 2;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<AluminumCuirass>() && legs.type == ModContent.ItemType<AluminumLeggings>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.moveSpeed += 0.12f;
            player.setBonus = "增加百分之12的移动速度";
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 18);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}