using miningcracks_take_on_luiafk.Utility;
using Terraria;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Potions.IndividualPotions
{
	public class UnlimitedCrates : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Crate Potion");
			base.Tooltip.SetDefault("Fish up all the crates you'll ever need.\nUse the settings hotkey to toggle the effect.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.Base(base.Item);
		}

		public override void UpdateInventory(Player player)
		{
			player.GetModPlayer<LuiafkPlayer>().buffs.Add("Crates");
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(2356, 30).AddTile(13).Register();
		}
	}
}