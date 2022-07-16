using miningcracks_take_on_luiafk.Utility;
using Terraria;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Potions.IndividualPotions
{
	public class UnlimitedCalming : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Calming Potion");
			base.Tooltip.SetDefault("Nice and quiet.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.Base(base.Item);
		}

		public override void UpdateInventory(Player player)
		{
			player.GetModPlayer<LuiafkPlayer>().buffs.Add("Calming");
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(2324, 30).AddTile(13).Register();
		}
	}
}