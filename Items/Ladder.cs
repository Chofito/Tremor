using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Ladder : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
			item.createTile = mod.TileType("Ladder");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ladder");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.SetResult(this, 2);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
