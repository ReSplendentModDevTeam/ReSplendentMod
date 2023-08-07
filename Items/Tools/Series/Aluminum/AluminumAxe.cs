using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ReSplendent.Items.Placeables;

namespace ReSplendent.Items.Tools.Series.Aluminum
{
    public class AluminumAxe : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Aluminumproducts.hjson file.

        public override void SetDefaults()
        {
            Item.ResearchUnlockCount = 1;
            Item.damage = 6;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 26;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 4.5f;
            Item.value = 200;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 0;
            Item.scale = 1;
            Item.axe = 8;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<AluminumBar>(), 8);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(35 / 716);
            recipe.Register();
        }
    }
}