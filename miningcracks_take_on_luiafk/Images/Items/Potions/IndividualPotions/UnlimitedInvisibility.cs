using miningcracks_take_on_luiafk.Utility;
using Terraria;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Potions.IndividualPotions
{
	public class UnlimitedInvisibility : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Invisibility Potion");
			base.Tooltip.SetDefault("'Cause it's useful for Truffle farming, apparently.\nUse the settings hotkey to toggle the effect.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.Base(base.Item);
		}

		public override void UpdateInventory(Player player)
		{
			player.GetModPlayer<LuiafkPlayer>().buffs.Add("Invisibility");
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(297, 30).AddTile(13).Register();
		}
	}
}