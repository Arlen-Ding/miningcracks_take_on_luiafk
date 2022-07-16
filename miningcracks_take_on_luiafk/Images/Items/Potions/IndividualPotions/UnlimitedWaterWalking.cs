using miningcracks_take_on_luiafk.Utility;
using Terraria;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Potions.IndividualPotions
{
	public class UnlimitedWaterWalking : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Water Walking Potion");
			base.Tooltip.SetDefault("Now you don't need to bother building that platform for Wall of Flesh.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.Base(base.Item);
		}

		public override void UpdateInventory(Player player)
		{
			player.GetModPlayer<LuiafkPlayer>().buffs[43] = true;
player.GetModPlayer<LuiafkPlayer>().buffs[0] = true;
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(302, 30).AddTile(13).Register();
		}
	}
}
