using miningcracks_take_on_luiafk.Utility;
using Terraria;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Potions
{
	public class UnlimitedMelee : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Melee Buffs");
			base.Tooltip.SetDefault("Ichor and tipsy.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.Base(base.Item);
		}

		public override void UpdateInventory(Player player)
		{
			player.GetModPlayer<LuiafkPlayer>().buffs.Add("Melee");
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(null, "UnlimitedTipsy").AddIngredient(null, "UnlimitedIchor").AddTile(13)
				.Register();
		}
	}
}