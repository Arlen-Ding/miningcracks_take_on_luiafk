using miningcracks_take_on_luiafk.Utility;
using Terraria;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Potions.IndividualPotions
{
	public class UnlimitedIchor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Ichor Flask");
			base.Tooltip.SetDefault("Your attacks inflict ichor.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.Base(base.Item);
		}

		public override void UpdateInventory(Player player)
		{
			player.GetModPlayer<LuiafkPlayer>().buffs.Add("Ichor");
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddRecipeGroup("Luiafk:EvilFlask", 30).AddTile(13).Register();
		}
	}
}
